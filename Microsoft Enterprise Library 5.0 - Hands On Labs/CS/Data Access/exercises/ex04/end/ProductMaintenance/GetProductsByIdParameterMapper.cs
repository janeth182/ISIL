using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ProductMaintenance
{
    class GetProductsByIdParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public GetProductsByIdParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CategoryID", parameterValues[0]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if(!command.Parameters.Contains("@CategoryID"))
            {
                db.AddInParameter(command, "@CategoryID", DbType.Int32);
            }
        }
    }
}
