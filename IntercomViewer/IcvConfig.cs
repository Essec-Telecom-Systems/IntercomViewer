using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntercomViewer {
    internal class IcvConfig {

        // RingCentral API data
        public string? rcApiClientId { get; set; }
        public string? rcApiClientSecret { get; set; }
        public string? rcApiUrl { get; set; }
        public string? rcApiJwt { get; set; }

        // List of intercom metadata
        public IList<Intercom>? intercoms { get; set; }

        public IcvConfig() {
            intercoms = new List<Intercom>();
            rcApiClientId = "";
            rcApiClientSecret = "";
            rcApiUrl = "";
            rcApiJwt = "";
        }

        public override bool Equals(object? obj) {
            return JsonSerializer.Serialize(this).Equals(JsonSerializer.Serialize(obj));
        }

        public override int GetHashCode() {
            return JsonSerializer.Serialize(this).GetHashCode();
        }

        public static IcvConfig fromJson(string json) {
            return JsonSerializer.Deserialize<IcvConfig>(json)!;
        }

        public string toJson() {
            JsonSerializerOptions jsOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            };
            return JsonSerializer.Serialize(this, jsOptions);
        }

    }
}
