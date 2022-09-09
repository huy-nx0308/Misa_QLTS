using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MISA.HCSN.Common.Entities;
using MySqlConnector;
using System.Text.RegularExpressions;
using Swashbuckle.AspNetCore.Annotations;

namespace MISA.Web07.NXHuy.HCSN.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        /// <summary>
        /// lấy toàn bộ tài sản
        /// </summary>
        [HttpGet]
        public IActionResult get()
        {
            //1 Khai báo kết nối
            var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@";

            //2 Kết nối tới MySql
            var sqlConnection = new MySqlConnection(connectionString);

            //3 Lấy dữ liệu
            var sqlCommand = "SELECT  * FROM asset";
            var assets = sqlConnection.Query<Asset>( sqlCommand);


            return Ok(assets);
        }
        /// <summary>
        /// Lấy mã tài sản lớn nhất để sau này tự sinh mã khi thêm mới
        /// </summary>
        [HttpGet("CodeAssetLastest")]
        public IActionResult getLastestAssetCode()
        {
            //1 Khai báo kết nối
            var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@";

            //2 Kết nối tới MySql
            var sqlConnection = new MySqlConnection(connectionString);

            //// 3 Lấy dữ liệu
            var sqlCommand = "SELECT MAX(FixedAssetCode) FROM asset";
            var assetCode = sqlConnection.QueryFirst<object>(sql: sqlCommand);
            string assetNewCode;
            if (assetCode != "")
            {
                var resultString = Regex.Match(assetCode.ToString(), @"\d{3}").Value;
                int number = int.Parse(resultString);
                number = number + 1;
                assetNewCode = "TS" + number;
            }
            else
            {
                assetNewCode = "TS001";
            }
            return Ok(assetNewCode);
        }

        /// <summary>
        /// Thêm mới tài sản
        /// </summary>
        /// 
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(Guid))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]

        public IActionResult AddAsset([FromBody] Asset asset)
        {
            try
            {
                //1 Khai báo kết nối
                var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@;Allow User Variables=True";

                //2 Kết nối tới MySql
                var sqlConnection = new MySqlConnection(connectionString);

                //3 Chuẩn bị câu lệnh INSERT INTO
                string sqlCommand = "INSERT INTO asset (FixedAssetId, FixedAssetCode, FixedAssetName, DepartmentId, DepartmentCode, DepartmentName, FixedAssetCategoryId, FixedAssetCategoryCode, FixedAssetCategoryName, Cost, Quantity, DepreciationRate, TrackedYear, LifeTime, CreatedBy, ModifiedBy) " +
                    "VALUES (@FixedAssetId, @FixedAssetCode, @FixedAssetName, @DepartmentId, @DepartmentCode, @DepartmentName, @FixedAssetCategoryId, @FixedAssetCategoryCode, @FixedAssetCategoryName, @Cost, @Quantity, @DepreciationRate, @TrackedYear, @LifeTime, @CreatedBy, @ModifiedBy);";

                //4 Chuẩn bị tham số cho câu lệnh
                var FixedAssetId = new Guid();
                var parameters = new DynamicParameters();
                parameters.Add("@FixedAssetId", FixedAssetId);
                parameters.Add("@FixedAssetCode", asset.FixedAssetCode);
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

                int numberOfAffectedRows = sqlConnection.Execute(sqlCommand, parameters);
                if (numberOfAffectedRows > 0)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status400BadRequest);
            }

        }
        /// <summary>
        /// Sửa tài sản
        /// </summary>
        /// 
        [HttpPut("{FixedAssetId}")]
        public IActionResult UpdateAsset([FromRoute]Guid FixedAssetId, [FromBody] Asset asset)
        {
            try
            {
                //1 Khai báo kết nối
                var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@;Allow User Variables=True";

                //2 Kết nối tới MySql
                var sqlConnection = new MySqlConnection(connectionString);

                //3 Chuẩn bị câu lệnh Update
                string sqlCommand = "UPDATE asset SET " +
                    "FixedAssetCode = @FixedAssetCode, " +
                    "FixedAssetName = @FixedAssetName, " +
                    "DepartmentId = @DepartmentId, " +
                    "DepartmentCode = @DepartmentCode, " +
                    "DepartmentName = @DepartmentName, " +
                    "FixedAssetCategoryId = @FixedAssetCategoryId, " +
                    "FixedAssetCategoryCode = @FixedAssetCategoryCode, " +
                    "FixedAssetCategoryName = @FixedAssetCategoryName, " +
                    "PurchaseDate = @PurchaseDate, " +
                    "Cost = @Cost, " +
                    "Quantity = @Quantity, " +
                    "DepreciationRate = @DepreciationRate, " +
                    "TrackedYear = @TrackedYear, " +
                    "LifeTime = @LifeTime, " +
                    "CreatedBy = @CreatedBy, " +
                    "ModifiedBy = @ModifiedBy " +
                    "WHERE FixedAssetId = @FixedAssetId;";

                //4 Chuẩn bị tham số đầu vào cho câu lệnh UPDATE
                var parameters = new DynamicParameters();
                parameters.Add("@FixedAssetId", FixedAssetId);
                parameters.Add("@FixedAssetCode", asset.FixedAssetCode);
                parameters.Add("@FixedAssetName", asset.FixedAssetName);
                parameters.Add("@DepartmentId", asset.DepartmentId);
                parameters.Add("@DepartmentCode", asset.DepartmentCode);
                parameters.Add("@DepartmentName", asset.DepartmentName);
                parameters.Add("@FixedAssetCategoryId", asset.FixedAssetCategoryId);
                parameters.Add("@FixedAssetCategoryCode", asset.FixedAssetCategoryCode);
                parameters.Add("@FixedAssetCategoryName", asset.FixedAssetCategoryName);
                parameters.Add("@PurchaseDate", asset.PurchaseDate);
                parameters.Add("@Cost", asset.Cost);
                parameters.Add("@Quantity", asset.Quantity);
                parameters.Add("@DepreciationRate", asset.DepreciationRate);
                parameters.Add("@TrackedYear", asset.TrackedYear);
                parameters.Add("@LifeTime", asset.LifeTime);
                parameters.Add("@CreatedBy", asset.CreatedBy);
                parameters.Add("@ModifiedBy", asset.ModifiedBy);

                //Thực hiện gọi vào db thực hiện câu lệnh update
                int numberOfAffectedRows = sqlConnection.Execute(sqlCommand, parameters);
                if (numberOfAffectedRows > 0) {
                    return StatusCode(StatusCodes.Status200OK, FixedAssetId);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }

    }

}
