using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MISA.HCSN.Common.Entities;
using MySqlConnector;

namespace MISA.HCSN.DL.AssetDL
{
 
    public class AssetDL:IAssetDL
    {
        /// <summary>
        /// Lấy toàn bộ tài sản
        /// </summary>
        public IEnumerable<Asset> get()
        {
            //1 Khai báo kết nối
            var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@";

            //2 Kết nối tới MySql
            var sqlConnection = new MySqlConnection(connectionString);

            //3 Lấy dữ liệu
            var sqlCommand = "SELECT  FixedAssetCategoryName, DepartmentName FROM asset";
            var assets = sqlConnection.Query<Asset>(sql: sqlCommand);

            
            return assets;
        }

        /// <summary>
        /// Lấy mã tài sản lớn nhất để sau này tự sinh mã khi thêm mới
        /// </summary>
        public string getLastestAssetCode()
        {
            //1 Khai báo kết nối
            var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@";

            //2 Kết nối tới MySql
            var sqlConnection = new MySqlConnection(connectionString);

            // 3 Lấy dữ liệu
            var sqlCommand = "SELECT MAX(FixedAssetCode) FROM asset";
            var assetCode = sqlConnection.QueryFirst<object>(sql: sqlCommand);

            return assetCode.ToString();
        }

        /// <summary>
        /// Thêm mới tài sản
        /// </summary>
        /// 
        public int Add(Asset asset)
        {
            //1 Khai báo kết nối
            var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@";

            //2 Kết nối tới MySql
            var sqlConnection = new MySqlConnection(connectionString);

            //3 Lấy dữ liệu
            var sqlCommand = "INSERT INTO asset value (@FixedAssetId, @FixAssetCode, @FixedAssetName)";
            //chuẩn bị tham số
            var parameters = new DynamicParameters();
            parameters.Add("@FixedAssetId", asset.FixedAssetId);
            parameters.Add("@FixAssetCode", asset.FixedAssetCode);
            parameters.Add("@FixedAssetName", asset.FixedAssetName);
            parameters.Add("@DepartmentId", asset.DepartmentId);
            parameters.Add("@DepartmentCode", asset.DepartmentCode);
            parameters.Add("@DepartmentName", asset.DepartmentName);
            parameters.Add("@FixedAssetCategoryId", asset.FixedAssetCategoryId);
            parameters.Add("@FixedAssetCategoryCode", asset.FixedAssetCategoryCode);
            parameters.Add("@FixedAssetCategoryName", asset.FixedAssetCategoryName);
            parameters.Add("@Cost", asset.Cost);
            parameters.Add("@Quantity", asset.Quantity);
            parameters.Add("@DepreciationRate", asset.DepreciationRate);
            parameters.Add("@TrackedYear", asset.TrackedYear);
            parameters.Add("@LifeTime", asset.LifeTime);
            parameters.Add("@CreatedBy", asset.CreatedBy);
            parameters.Add("@ModifiedBy", asset.ModifiedBy);
            var result = sqlConnection.Execute(sql: sqlCommand, param: asset);
            return result;
        }
    }
}
