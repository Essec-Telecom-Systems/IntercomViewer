using IntercomViewer;

namespace IntercomViewer.Tests {
    [TestClass]
    public sealed class IcvConfigTests {
        [TestMethod]
        public void TestJsonSerialization() {
            string jsonAssertValue = "{\"rcApiClientId\":\"123\",\"rcApiClientSecret\":\"secret\",\"rcApiUrl\":\"https://api.local.dev\",\"rcApiJwt\":\"jwt-token\",\"intercoms\":[{\"name\":\"Intercom 1\",\"incommingNumber\":\"123\",\"videoUrl\":\"http://ic1.local.dev:8080/stream\",\"actionUrl\":\"http://ic1.local.dev:8080/toggle\"}]}";
            IcvConfig config = new IcvConfig { 
                rcApiClientId = "123",
                rcApiClientSecret = "secret",
                rcApiUrl = "https://api.local.dev",
                rcApiJwt = "jwt-token",
                intercoms = new List<Intercom> { 
                    new Intercom { 
                        name = "Intercom 1",
                        incommingNumber = "123",
                        actionUrl = "http://ic1.local.dev:8080/toggle",
                        videoUrl = "http://ic1.local.dev:8080/stream"
                    } 
                }
            };
            string jsonValue = config.toJson();
            Assert.AreEqual(jsonValue, jsonAssertValue);
        }

        [TestMethod]
        public void TestJsonDeserialization() {
            string jsonValue = "{\"rcApiClientId\":\"123\",\"rcApiClientSecret\":\"secret\",\"rcApiUrl\":\"https://api.local.dev\",\"rcApiJwt\":\"jwt-token\",\"intercoms\":[{\"name\":\"Intercom 1\",\"incommingNumber\":\"123\",\"videoUrl\":\"http://ic1.local.dev:8080/stream\",\"actionUrl\":\"http://ic1.local.dev:8080/toggle\"}]}";
            IcvConfig assertConfig = new IcvConfig {
                rcApiClientId = "123",
                rcApiClientSecret = "secret",
                rcApiUrl = "https://api.local.dev",
                rcApiJwt = "jwt-token",
                intercoms = new List<Intercom> {
                    new Intercom {
                        name = "Intercom 1",
                        incommingNumber = "123",
                        actionUrl = "http://ic1.local.dev:8080/toggle",
                        videoUrl = "http://ic1.local.dev:8080/stream"
                    }
                }
            };
            IcvConfig config = IcvConfig.fromJson(jsonValue);
            Assert.AreEqual(config, assertConfig);
        }
    }
}
