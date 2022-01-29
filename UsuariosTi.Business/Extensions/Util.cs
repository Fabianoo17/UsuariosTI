using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;


namespace Corretora.Business.Extensions
{
    public static class Util
    {
        public static byte[] GetPhoto(string matricula)
        {
            using (var context = new PrincipalContext(ContextType.Domain, "corp.caixa.gov.br", "s7562226", "wLawrLa5"))
            {
                var user = UserPrincipal.FindByIdentity(context, matricula);
                if (user != null)
                {
                    using (DirectoryEntry de = (DirectoryEntry)user.GetUnderlyingObject())
                    {
                        return de.Properties["thumbnailPhoto"]?.Value != null
                            ? (byte[])de.Properties["thumbnailPhoto"]?.Value
                            : new byte[0];

                      
                    }
                }
            }

            return null;
        }

        public static string GetCargo(string matricula)
        {
            using (var context = new PrincipalContext(ContextType.Domain, "corp.caixa.gov.br", "s7562226", "wLawrLa5"))
            {
                var user = UserPrincipal.FindByIdentity(context, matricula);
                if (user != null)
                {
                    using (DirectoryEntry de = (DirectoryEntry)user.GetUnderlyingObject())
                    {
                        var cargo = de.Properties["title"].Value.ToString();
                        return cargo;
                    }
                }
            }
            return "";
        }
    }
}

