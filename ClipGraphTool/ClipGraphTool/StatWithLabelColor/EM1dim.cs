using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipGraphTool.StatWithLabelColor
{
    /// <summary>
    /// 1次元のEMアルゴリズム.
    /// ・1次元で正規分布なのもほぼ明らかなので、演算精度には問題ないはず
    /// ・C#は処理時間がかかるが、今回の場合はたいして問題にならない
    /// ・2要素限定に設定
    /// </summary>
    public class EM1dim
    {
        private readonly int ITERATION_COUNT = 10;
        private readonly int DIMENSION = 2;

        public double DefaultSigma
        {
            get;
            set;
        }

        public class EMGaussian
        {
            public int Number;
            public double Average;
            public double Variation;
            public double MixingParameter;
        }

        private List<DataStructure> _data;

        public EMGaussian[] DistResult
        {
            get;
            private set;
        }


        public EM1dim(List<DataStructure> data)
        {
            _data = new List<DataStructure>();
            _data.AddRange(data);

            DistResult = new EMGaussian[DIMENSION];
            for (int i = 0; i < DIMENSION; i++)
            {
                DistResult[i] = new EMGaussian();
            }

            DefaultSigma = 0.1;
        }

        /// <summary>
        /// EM法の演算
        /// </summary>
        public void Calculate()
        {
            if (_data.Count == 0)
            {
                DistResult = new EMGaussian[0];
                return;
            }
            else
            {
                DistResult = new EMGaussian[DIMENSION];
                for (int i = 0; i < DIMENSION; i++)
                {
                    DistResult[i] = new EMGaussian();
                }
            }

            // データ取り出し
            List<double> _areadata = new List<double>();
            foreach( var onedata in _data) {
                _areadata.Add(onedata.Areamm);
            }

            // Gaussian結果のバッファを確保
            EMGaussian[] tmpdist = new EMGaussian[DistResult.Length];
            for (int i = 0; i < DistResult.Length; i++)
            {
                tmpdist[i] = new EMGaussian()
                {
                    Average = ((DistResult.Length - 1 - i) * _areadata.Min() + i * _areadata.Max()) / (DistResult.Length - 1),
                    Variation = DefaultSigma,
                    MixingParameter = 1.0 / DistResult.Length
                };
            }

            // 確率密度関数と重み
            double[][] pdensity_gaussian = new double[DistResult.Length][];
            double[][] pdensity_ratio = new double[DistResult.Length][];
            double[][] pdensity_average = new double[DistResult.Length][];
            double[][] pdensity_var = new double[DistResult.Length][];
            for( int i = 0 ; i < DistResult.Length; i ++ ) {
                pdensity_gaussian[i] = new double[_areadata.Count];
                pdensity_ratio[i] = new double[_areadata.Count];
                pdensity_average[i] = new double[_areadata.Count];
                pdensity_var[i] = new double[_areadata.Count];
            }

            // 反復演算
            for (int i = 0; i < ITERATION_COUNT; i++)
            {
                for (int j = 0; j < pdensity_gaussian.Length; j++)
                {
                    pdensity_gaussian[j] = _areadata.Select((val) =>
                        {
                            double gaussval = Math.Exp(-(val - tmpdist[j].Average) * (val - tmpdist[j].Average) / (2 * tmpdist[j].Variation));
                            gaussval /= Math.Sqrt(2 * Math.PI * tmpdist[j].Variation);
                            gaussval *= tmpdist[j].MixingParameter;
                            return gaussval;
                        }).ToArray();
                }

                // sum{p_i}
                for (int k = 0; k < _areadata.Count; k++)
                {
                    double sumadd = 0;
                    for (int j = 0; j < pdensity_gaussian.Length; j++)
                    {
                        sumadd += pdensity_gaussian[j][k];
                    }

                    for (int j = 0; j < pdensity_gaussian.Length; j++)
                    {
                        pdensity_ratio[j][k] = pdensity_gaussian[j][k] / sumadd;
                        pdensity_average[j][k] = pdensity_ratio[j][k] * _areadata[k];
                        pdensity_var[j][k] = pdensity_ratio[j][k] * (_areadata[k] - tmpdist[j].Average) * (_areadata[k] - tmpdist[j].Average); 
                    }
                }


                // renew
                for( int j = 0 ; j < pdensity_gaussian.Length; j ++ ) {
                    DistResult[j].MixingParameter = pdensity_ratio[j].Sum() / _areadata.Count;
                    DistResult[j].Average = pdensity_average[j].Sum() / pdensity_ratio[j].Sum();
                    DistResult[j].Variation = pdensity_var[j].Sum() / pdensity_ratio[j].Sum();

                    DistResult[j].Number = (int)Math.Round(DistResult[j].MixingParameter * _areadata.Count);
                }
            }
        }




    }
}
