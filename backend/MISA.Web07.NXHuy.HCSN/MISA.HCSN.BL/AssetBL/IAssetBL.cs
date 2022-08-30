using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;
using MISA.HCSN.Common.Entities;


namespace MISA.HCSN.BL.AssetBL
{
    public interface IAssetBL
    {
        /// <summary>
        /// lấy toàn bộ tài sản
        /// </summary>
        /// 
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
