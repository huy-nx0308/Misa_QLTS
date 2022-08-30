using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.HCSN.Common.Entities;
namespace MISA.HCSN.DL.AssetDL
{
   
    public interface IAssetDL
    {
        /// <summary>
        /// Lấy toàn bộ các tài sản
        /// </summary>

        IEnumerable<Asset> get();

        /// <summary>
        /// Lấy mã tài sản lớn nhất để sau này tự sinh mã khi thêm mới
        /// </summary>
        string getLastestAssetCode();


        /// <summary>
        /// Thêm mới tài sản
        /// </summary>
        /// 
        int Add(Asset asset);

       

    }
}
