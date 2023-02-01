using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mysqlx;
using TestXSIS.Data;

namespace TestXSIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MysqlDBContext db;
        public MovieController(MysqlDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            GeneralOutputModel output = new GeneralOutputModel();
            try
            {
                var movieList = db.movies.ToList();
                output.Status = "OK";
                output.Result = movieList;
                output.Message = "Berhasil mengambil data Movie";

                return Ok(output);
            } catch (Exception ex)
            {
                output.Status = "NG";
                output.Message = ex.ToString();

                return BadRequest(output);
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int Id)
        {
            GeneralOutputModel output = new GeneralOutputModel();
            try
            {
                var movieDetail = db.movies.Where(p => p.id == Id).FirstOrDefault();
                output.Status = "OK";
                output.Result = movieDetail;
                output.Message = "Berhasil mengambil data detail Movie";

                return Ok(output);
            }
            catch (Exception ex)
            {
                output.Status = "NG";
                output.Message = ex.ToString();

                return BadRequest(output);
            }
        }

        [HttpPost]
        public IActionResult Post([FromForm] ParamMovie pr)
        {
            GeneralOutputModel output = new GeneralOutputModel();
            try
            {
                if (string.IsNullOrWhiteSpace(pr.title))
                {
                    output.Status = "NG";
                    output.Message = "Judul movie tidak boleh kosong.";

                    return BadRequest(output);
                }
                if (string.IsNullOrWhiteSpace(pr.description))
                {
                    output.Status = "NG";
                    output.Message = "Deskripsi movie tidak boleh kosong.";

                    return BadRequest(output);
                }
                var movieTitleExist = db.movies.Where(p => p.title == pr.title).FirstOrDefault();
                if (movieTitleExist != null)
                {
                    output.Status = "NG";
                    output.Result = movieTitleExist;
                    output.Message = "Movie dengan judul " + pr.title + " Sudah ada pada sistem";

                    return Ok(output);
                }
                Movie movies = new Movie();
                movies.title = pr.title;
                movies.description = pr.description;
                movies.rating = pr.rating;
                movies.image = pr.image;
                movies.created_at = DateTime.Now;
                movies.updated_at = DateTime.Now;
                db.movies.Add(movies);
                db.SaveChanges();

                output.Status = "OK";
                output.Result = movies.id;
                output.Message = "Berhasil menambah data Movie";

                return Ok(output);
            }
            catch (Exception ex)
            {
                output.Status = "NG";
                output.Message = ex.ToString();

                return BadRequest(output);
            }
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id,[FromForm] ParamMovie pr)
        {
            GeneralOutputModel output = new GeneralOutputModel();
            try
            {
                if (string.IsNullOrWhiteSpace(pr.title))
                {
                    output.Status = "NG";
                    output.Message = "Judul movie tidak boleh kosong.";

                    return BadRequest(output);
                }
                if (string.IsNullOrWhiteSpace(pr.description))
                {
                    output.Status = "NG";
                    output.Message = "Deskripsi movie tidak boleh kosong.";

                    return BadRequest(output);
                }
                var movieDetail = db.movies.Where(p => p.id == id).FirstOrDefault();
                if (movieDetail == null)
                {
                    output.Status = "NG";
                    output.Message = "Data movie tidak ditemukan";

                    return Ok(output);
                }
                movieDetail.title = pr.title;
                movieDetail.description = pr.description;
                movieDetail.rating = pr.rating;
                movieDetail.image = pr.image;
                movieDetail.updated_at = DateTime.Now;

                db.SaveChanges();

                output.Status = "OK";
                output.Result = movieDetail;
                output.Message = "Berhasil merubah data Movie";

                return Ok(output);
            }
            catch (Exception ex)
            {
                output.Status = "NG";
                output.Message = ex.ToString();

                return BadRequest(output);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Patch(int id)
        {
            GeneralOutputModel output = new GeneralOutputModel();
            try
            {
                var movieDetail = db.movies.Where(p => p.id == id).FirstOrDefault();
                if (movieDetail == null)
                {
                    output.Status = "NG";
                    output.Message = "Data movie tidak ditemukan";

                    return Ok(output);
                }
                db.movies.Remove(movieDetail);
                db.SaveChanges();

                output.Status = "OK";
                output.Result = movieDetail;
                output.Message = "Berhasil menghapus data Movie";

                return Ok(output);
            }
            catch (Exception ex)
            {
                output.Status = "NG";
                output.Message = ex.ToString();

                return BadRequest(output);
            }
        }
    }
}
