using ACT.Core.Enums;
using ACT.Core.Interfaces.Common;
using ACT.Core.Interfaces.Data;
using ACT.Core.Interfaces.Data.JSON_Contracts;
using ACT.Core.Interfaces.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{
   public class Virtual_I_Author : Virtual_I_Exportable, I_Author
   {
      public virtual string Actid { get; set; }
      public virtual string ExternalId { get; set; }
      public virtual string FirstName { get; set; }
      public virtual string LastName { get; set; }
      public virtual string EmailAddress { get; set; }
      public virtual string Company { get; set; }
      public virtual string DateLastEdited { get; set; }
      public virtual string Description { get; set; }
      public virtual string Validation_Hash { get; set; }
      
      public List<Virtual_I_NameValue> Additional_Author_Information = new List<Virtual_I_NameValue>();

      public virtual List<I_NameValue> AdditionalInformation
      {
         get { return Additional_Author_Information.ToList<I_NameValue>(); }
         set
         {
            Additional_Author_Information.Clear();
            foreach (var i in value)
            {
               Additional_Author_Information.Add(new Virtual_I_NameValue() { Name = i.Name, Value = i.Value });
            }
         }
      }
   }
}
