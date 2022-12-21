using Microsoft.Data.SqlClient;
using System.Data;

namespace OnlineDateApplication.MVC.Controllers
{
    public class UserRegistration
    {
        SqlCommand cmd = new SqlCommand("sp_KayitVarmi", cnn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@mail", mail);                cmd.Parameters.AddWithValue("@abonead",kisiad);                
        SqlParameter param = new SqlParameter("@sonuc", SqlDbtype.Int);
        param.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(param);
        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();
        int sonuc = Convert.ToInt32(param.Value);
        if(Sonuc>0)
        {
//Kayıt Başarılıysa buraya düşer
        }
        else
        {
//zaten öyle bir mail varsa ve kaydedilmemişse buraya düşer
        }

    }
}
