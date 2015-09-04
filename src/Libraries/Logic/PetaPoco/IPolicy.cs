using MixERP.Net.Framework;

namespace PetaPoco
{
    public interface IPolicy
    {
        string ObjectNamespace { get; set; }
        string ObjectName { get; set; }
        AccessTypeEnum AccessType { get; set; }
        bool HasAccess { get; }
        long LoginId { get; set; }
        void Validate();
    }
}