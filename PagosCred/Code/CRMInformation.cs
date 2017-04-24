using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PagosCredijal
{
    public class CRMInformation
    {
        private String idOpportunity;
        public CRMInformation(String idOpportunity)
        {
            this.idOpportunity = idOpportunity;
        }

        public String GetCustomerByOpportunity()
        {
            try
            {
                String query = String.Format(@"SELECT *
                                            FROM PaymentsOportunity PO
                                            INNER JOIN PaymentsCustomer PC ON PO.FKCliente = PC.PKCustomer
                                            WHERE PO.PKOportunity = '{0}'", this.idOpportunity);
                DataBaseSettings db = new DataBaseSettings();
                DataTable aux = db.GetDataTable(query);

                if(aux.Rows.Count > 0)
                {
                    return aux.Rows[0]["PKCustomerSL"].ToString().Trim();
                }

                throw new Exception("El cliente no fue encontrado");

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}