using MISA.HCSN.DL.AssetDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.HCSN.Common.Entities;

namespace MISA.HCSN.BL.AssetBL
{
    public class AssetBL
    {
        private IAssetDL _assetDL;

        public AssetBL(IAssetDL assetDL)
        {
            _assetDL = assetDL;
        }


    }
}
