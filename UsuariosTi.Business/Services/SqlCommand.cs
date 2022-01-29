namespace Corretora.Business.Services
{
    internal class SqlCommand
    {
        private string v;
        private SqlConnection con;

        public SqlCommand(string v, SqlConnection con)
        {
            this.v = v;
            this.con = con;
        }
    }
}