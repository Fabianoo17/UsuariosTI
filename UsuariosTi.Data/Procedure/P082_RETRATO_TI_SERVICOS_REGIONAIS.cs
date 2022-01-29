using System.Data;
using System.Data.SqlClient;

namespace Corretora.Data.Procedure
{
    public class P082_RETRATO_TI_SERVICOS_REGIONAIS
    {
        public DataTable RetornarDadosComoDT()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            var conexao = new SqlConnection(@"Server=CCTDCDADNT0003\SQL7562PRD17;Database=INOVA_CETEC;User ID=usr_link;Password=cetec02");
            cmd = new SqlCommand("P082_RETRATO_TI_SERVICOS_REGIONAIS", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            
            return dt;
        }
    }
}
