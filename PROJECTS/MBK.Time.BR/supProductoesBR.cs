using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBK.Time.BusinessObjects;
using SFSdotNet.Framework.BR;
using SFSdotNet.Framework.My;

namespace MBK.Time.BR
{
    public partial class supProductosBR
    {
        /// <summary>
        /// Crea o actualiza un elemento
        /// </summary>
        /// <param name="item">Elemento nuevo o existente para actualizar</param>
        /// <param name="contextRequest">Parámetro de contexto</param>
        /// <returns></returns>
        public supProducto CreateOrUpdate(supProducto item, ContextRequest contextRequest)
        {

            var existent = this.GetBy(p => p.codart == item.codart, contextRequest).FirstOrDefault();
            if (existent == null)
            {
               existent =  Create(item, contextRequest);
            }else
            {
                existent = Update(item, contextRequest);
            }

            return existent;

        }
        public void CreateOrUpdate(List<supProducto> items, ContextRequest contextRequest)
        {

            var existentAll = this.GetBy(p => true) ;

            



        }


        partial void OnCreating(object sender, BusinessRulesEventArgs<supProducto> e)
        {
            // establecer fecha de creación

        }
        partial void OnUpdated(object sender, BusinessRulesEventArgs<supProducto> e)
        {
            // establecer fecha de actualización

        }
        partial void OnCreated(object sender, BusinessRulesEventArgs<supProducto> e)
        {
            
        }


    }
}
