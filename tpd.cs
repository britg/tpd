using UnityEngine;
using System.Collections;

/* Tavernpunk Unity3d Helpers
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
public class tpd {



  public static bool BeginsWith (string s, string match) {
    if (s.Length < match.Length) {
      return false;
    }

    return (s.Substring(0, match.Length) == match);
  }

}
