namespace practice.Collection
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class MyColletion<T>
    {
        private List<T> list = new List<T>();

        public async void AddAsync(T item)
        {
            Random rnd = new Random();
            await Task.Run(() =>
            {
                Task.Delay(rnd.Next(0, 400) + 100);
                this.list.Add(item);
            });
        }
    }
}
