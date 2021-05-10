using System;

namespace Bloodthirst.BDeepCopy
{
    internal class DefaultCopierFactory : IBCopyFactory
    {
        bool IBCopyFactory.CanCopy(Type t)
        {
            return true;
        }

        IBCopierInternal IBCopyFactory.GetCopier(Type t)
        {
            return new BCopierComplexType(t);
        }
    }
}
