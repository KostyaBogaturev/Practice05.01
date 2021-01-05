namespace practice.Collection
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MyColletion<T>
    {
        private List<T> list = new List<T>();
        private Random rnd = new Random();

        public async void AddAsync(T item)
        {
            await Task.Run(() =>
            {
                Task.Delay(this.rnd.Next(0, 400) + 100);
                this.list.Add(item);
            });
        }

        public async void AddRangeAsync(T[] item)
        {
            await Task.Run(() =>
            {
                Task.Delay(this.rnd.Next(0, 400) + 100);
                this.list.AddRange(item);
            });
        }

        public async void RemoveItemAsync(T item)
        {
            await Task.Run(() =>
            {
                Task.Delay(this.rnd.Next(0, 400) + 100);
                this.list.Remove(item);
            });
        }
    }
}
