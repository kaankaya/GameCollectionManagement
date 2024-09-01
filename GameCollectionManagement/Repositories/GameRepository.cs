using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    public class GameRepository : BaseRepository<Game>
    {
        public override List<Game> GetAll()
        {
            string query = "SELECT * FROM games";
            DataTable dataTable = ExecuteQuery(query);
            List<Game> games = new List<Game>();
            foreach (DataRow row in dataTable.Rows)
            {
                games.Add(DataMappers.MapToGame(row));
            }
            return games;
        }//End GetAll()

        public List<Game> GetList()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM games",connection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Game> games = new List<Game>();
                while (reader.Read())
                {
                    Game game = new Game();
                    game.Id = Convert.ToInt32(reader["Id"]);
                    game.Name = reader["Name"].ToString();
                    game.Genre = reader["Genre"].ToString();
                    game.Platform = reader["Platform"].ToString();
                    game.ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    game.PlayTime = Convert.ToInt32(reader["PlayTime"]);
                    game.CoverImage = reader["CoverImage"] as byte[];

                    games.Add(game);
                }
                reader.Close();
                return games;
            }
        }//End GetList()

        public override Game GetById(int id)
        {
            string query = "SELECT * FROM games WHERE Id=@Id";
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id", id)
                            .Build();
            DataTable dataTable = ExecuteQuery(query,parameters);
            DataRow row = dataTable.Rows[0];
           
            return DataMappers.MapToGame(row);

        }//End GetById()


        public override void Add(Game entity)
        {
            string query = "insert into Games(Name,Genre,Platform,ReleaseDate,PlayTime,CoverImage) values (@Name,@Genre,@Platform,@ReleaseDate,@PlayTime,@CoverImage)";
            //SqlParameter[] param = new SqlParameter[]
            //{
            //    new SqlParameter("@Name",entity.Name),
            //    new SqlParameter("@Genre",entity.Genre),
            //    new SqlParameter("@Platform",entity.Platform),
            //    new SqlParameter("@ReleaseDate",entity.ReleaseDate),
            //    new SqlParameter("@PlayTime",entity.PlayTime),
            //    new SqlParameter("@CoverImage",entity.CoverImage),
            //};
            var parameters = new SqlParameterBuilder()
                               .AddParameter("@Name", entity.Name)
                               .AddParameter("@Genre", entity.Genre)
                               .AddParameter("@Platform", entity.Platform)
                               .AddParameter("@ReleaseDate", entity.ReleaseDate)
                               .AddParameter("@PlayTime", entity.PlayTime)
                               .AddParameterWithValue("@CoverImage", entity.CoverImage,SqlDbType.VarBinary)
                               .Build();
            ExecuteNonQuery(query, parameters);
        }//end Add()

        public override void Update(Game entity)
        {
            string query = "UPDATE Games SET Name=@Name,Genre=@Genre,Platform=@Platform,ReleaseDate=@ReleaseDate,PlayTime=@PlayTime,CoverImage=@CoverImage WHERE Id=@Id";
            //SqlParameter[] param = new SqlParameter[]
            //{
            //    new SqlParameter("@Id",entity.Id),
            //    new SqlParameter("@Name",entity.Name),
            //    new SqlParameter("@Genre",entity.Genre),
            //    new SqlParameter("@Platform",entity.Platform),
            //    new SqlParameter("@ReleaseDate",entity.ReleaseDate),
            //    new SqlParameter("@PlayTime",entity.PlayTime),
            //    new SqlParameter("@CoverImage",entity.CoverImage),
            //};

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", entity.Id)
                                .AddParameter("@Name", entity.Name)
                                .AddParameter("@Genre", entity.Genre)
                                .AddParameter("@Platform", entity.Platform)
                                .AddParameter("@ReleaseDate", entity.ReleaseDate)
                                .AddParameter("@PlayTime", entity.PlayTime)
                                .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)
                                .Build();
            ExecuteNonQuery(query, parameters);
        }//End Update()

        public override void Delete(int id)
        {
            string query = "DELETE FROM Games Where Id=@Id";
            //SqlParameter[] param = new SqlParameter[]
            //{
            //    new SqlParameter("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id", id)
                            .Build();
            ExecuteNonQuery(query, parameters);
        }//End Delete(int id)

        public override void Delete(Game entity)
        {
            Delete(entity.Id);
        }// End Delete(entity)

        public List<string> GetGenres()
        {
            var games = GetAll();
            List<string> genres = new List<string>();
            foreach(var game in games)
            {
                if(!genres.Contains(game.Genre))
                    genres.Add(game.Genre);
            }

            return genres;
        }
    }
}
