using System.Collections.Generic;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        //metodo para apenas uma assinatura
        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotificarion(new Notification("Premium", "Aluno com assinatura ativa"));
                return;
            }
            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    }
}