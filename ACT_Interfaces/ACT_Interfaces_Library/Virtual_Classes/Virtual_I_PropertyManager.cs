using ACT.Core.Interfaces.Common;
using ACT.Core.Interfaces.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{

   /// <summary>
   /// I_PropertyManager Helper Class
   /// </summary>
   public class Virtual_I_PropertyManager : I_PropertyManager
   {

      /// <summary>
      /// Public Properties - List<string>
      /// </summary>
      public virtual List<string> PublicProperties
      {
         get
         {
            return this.GetType().GetProperties().Select(x => x.Name).ToList();
         }
      }

      /// <summary>
      /// Get Property Type - PropertyName
      /// </summary>
      /// <param name="PropertyName">Name of the Property</param>
      /// <returns>Type of the Property</returns>
      public virtual Type GetPropertyType(string PropertyName)
      {
         return this.GetType().GetProperties().First(x => x.Name == PropertyName).PropertyType;
      }

      /// <summary>
      /// Returns the Property Value or Null
      /// </summary>
      /// <param name="PropertyName">Name of the Property</param>
      /// <returns></returns>
      public virtual object GetPropertyValue(string PropertyName)
      {
         try
         {
            return this.GetType().GetProperties().First(x => x.Name == PropertyName).GetValue(this);
         }
         catch (Exception ex)
         {
            //TODO Log Error
            return null;
         }
      }

      /// <summary>
      /// Set the Property Value
      /// </summary>
      /// <param name="PropertyName">Name of the Property</param>
      /// <param name="value">Value to Set the Property Too</param>
      /// <returns>I_Result</returns>
      public virtual I_Result SetPropertyValue(string PropertyName, object value)
      {
         Virtual_I_Result _TmpReturn = new Virtual_I_Result();
         _TmpReturn.Success = false;

         try { this.GetType().GetProperties().First(x => x.Name == PropertyName).SetValue(this, value); }
         catch (Exception ex)
         {
            // TODO LOG
            _TmpReturn.Success = false;
            _TmpReturn.Exceptions = new List<Exception>();
            _TmpReturn.Exceptions.Add(ex);
         }

         if (GetPropertyValue(PropertyName) == value) { _TmpReturn.Success = true; }

         return _TmpReturn;
      }
   }

}