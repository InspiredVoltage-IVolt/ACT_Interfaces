namespace ACT.Core.Interfaces.Reflection
{
    public interface I_PropertyManager
    {
        /// <summary>Get all of the Public Properties in the class</summary>
        /// <returns><![CDATA[List<string> of all the property names]]></returns>
        List<string> PublicProperties { get; }

        /// <summary>Return a property value by name</summary>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        object GetPropertyValue(string PropertyName);

        /// <summary>Returns the type of the property</summary>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        Type GetPropertyType(string PropertyName);

        /// <summary>
        /// Trys to set a property using the propertyname and the value. Case sensitive people.
        /// </summary>
        /// <param name="PropertyName">Case Sensitive Property Name</param>
        /// <param name="value">value</param>
        /// <returns>I_TestResult - Specifying if the Set was successfull</returns>
        Common.I_Result SetPropertyValue(string PropertyName, object value);
    }
}
