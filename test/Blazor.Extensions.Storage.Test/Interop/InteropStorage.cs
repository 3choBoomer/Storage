using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazor.Extensions.Storage.Test.Interop
{
    /// <summary>
    /// Interop calls to JavaScript Local and Session storage via Blazor's <see cref="jSRuntime"/>.
    /// </summary>
    public class InteropStorage
    {
        private IJSRuntime jSRuntime;

        public InteropStorage(IJSRuntime jsRuntime)
        {
            this.jSRuntime = jsRuntime;
        }

        /// <summary>
        /// Returns a session storage value.
        /// </summary>
        /// <param name="key">Key associated with stroed value.</param>
        /// <returns>Task that returns the stored value as a string.</returns>
        public async Task<string> GetSessionStorage(string key)
        {
            return await this.jSRuntime.InvokeAsync<string>(
                "getSessionStorage",
                key
            );
        }

        /// <summary>
        /// Returns a local storage value.
        /// </summary>
        /// <param name="key">Key associated with stroed value.</param>
        /// <returns>Task that returns the stored value as a string.</returns>
        public async Task<string> GetLocalStorage(string key)
        {
            return await this.jSRuntime.InvokeAsync<string>(
                "getLocalStorage",
                key
            );
        }
    }
}
