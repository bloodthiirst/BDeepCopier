using System;
using System.Reflection;

namespace Bloodthirst.BDeepCopy
{
    public interface IBCopierOverride
    {
        Type AttributeType { get; }
        object CopyOverride(in object original, MemberInfo memberInfo, CopierSettingAttribute settingAttribute);
    }

    internal interface IBCopierOverride<TAttribute> : IBCopierOverride where TAttribute : CopierSettingAttribute
    {
        object CopyOverride(in object original, MemberInfo memberInfo, TAttribute attribute);
    }
}
