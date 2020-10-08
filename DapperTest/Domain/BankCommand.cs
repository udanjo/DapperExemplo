using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperTest.Domain
{
    public static class BankCommand
    {
        /// <summary>
        /// Comando para buscar Banco por ID
        /// </summary>
        public const string _GetById = "SELECT * FROM MI_BANCO WHERE ID = @ID";

        /// <summary>
        /// Comando de Insert do Banco
        /// </summary>
        public const string _Insert = "INSERT INTO MI_BANCO(CODIGO, DESCRICAO) VALUES(@CODIGO, @DESCRICAO)";

        /// <summary>
        /// Comando de update do Banco
        /// </summary>
        public const string _Update = @"UPDATE MI_BANCO SET
                                        CODIGO = @CODIGO, 
                                        DESCRICAO = @DESCRICAO
                                        WHERE ID = @ID";
    }
}
