/* JSONResource
 * Brit Gardner
 * http://britg.com
 * @britg
 *
 * A set of helper classes that can be dropped into a
 * Unity3D assets folder.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

 */
using SimpleJSON;

public class JSONSourceData : Dictionary<string, Dictionary<string, JSONNode>> {}

public abstract class JSONResource {
  public const string EXT = ".json";
  public static JSONSourceData jsonCache = new JSONSourceData();

  public string type;
  public string sourceKey;

  public JSONResource () {
    guid = System.Guid.NewGuid().ToString();
  }

  public JSONResource (string _type, string _key) {
    guid = System.Guid.NewGuid().ToString();
    type = _type;
    sourceKey = _key;
  }

  public string guid;

  JSONNode _sourceNode;
  public JSONNode sourceNode {
    get {
      if (_sourceNode == null) {
        _sourceNode = JSONResource.jsonCache[type][sourceKey];
      }
      return _sourceNode;
    }
  }
  public string key { get { return sourceNode["key"].Value; } }
  public string name { get { return sourceNode["name"].Value; } }
}