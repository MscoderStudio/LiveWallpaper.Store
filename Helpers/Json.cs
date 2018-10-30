﻿using System.Threading.Tasks;

using Newtonsoft.Json;


namespace LiveWallpaper.Store.Helpers
{
    public static class Json
    {
        public static async Task<T> ToObjectAsync<T>(string value)
        {
            return await Task.Run(() =>
            {
                return JsonConvert.DeserializeObject<T>(value);
            });
        }

        public static async Task<string> StringifyAsync(object value)
        {
            var result = await Task.Run(() =>
             {
                 return JsonConvert.SerializeObject(value);
             });
            return result;
        }
    }
}
