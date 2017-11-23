using Aws.Kinesis.Protobuf;

namespace KPLNETInterface
{
    public interface IMessageManager
    {
        void put(Message data);

        bool try_take(out Message dest);
    }
}
