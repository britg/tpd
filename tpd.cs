using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* Tavernpunk Unity3d Helpers
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
public class tpd {


  /*
   * Strings
   */

  public static bool BeginsWith (string s, string match) {
    if (s.Length < match.Length) {
      return false;
    }

    return (s.Substring(0, match.Length) == match);
  }

  public static string AddOrdinal (int num) {
    if (num <= 0) return num.ToString();

    switch (num % 100) {
      case 11:
      case 12:
      case 13:
        return num + "th";
    }

    switch (num % 10) {
      case 1:
        return num + "st";
      case 2:
        return num + "nd";
      case 3:
        return num + "rd";
      default:
        return num + "th";
    }

  }

  public static string AddSign (int n) {
    if (n > 0) return "+" + n;
    return "-" + Mathf.Abs(n);
  }

  /*
   * Randomization / Roll Percent
   */

  public static string RollSet (Hashtable hash) {
    float sum = 0f;
    foreach (DictionaryEntry pair in hash) {
      sum += (float)pair.Value;
    }

    float rand = Random.Range(0f, sum);

    float running = 0;
    string chosen = null;
    foreach (DictionaryEntry pair in hash) {
      running += (float)pair.Value;
      if (rand <= running) {
        chosen = (string)pair.Key;
        break;
      }
    }

    return chosen;
  }

  public static string RollSet (Dictionary<string, float> dict) {
    float sum = 0f;
    foreach (KeyValuePair<string, float> pair in dict) {
      sum += (float)pair.Value;
    }

    float rand = Random.Range(0f, sum);

    float running = 0;
    string chosen = null;
    foreach (KeyValuePair<string, float> pair in dict) {
      running += (float)pair.Value;
      if (rand <= running) {
        chosen = (string)pair.Key;
        break;
      }
    }

    return chosen;
  }

  public static bool RollPercent (float chance) {
    float rand = Random.Range(0f, 100f);
    return rand < chance;
  }

  public static float RollRange (RangeAttribute range) {
    return Random.Range(range.min, range.max);
  }

  /*
   * Colors
   */

  public static string ColorToHex (Color32 color) {
    string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
    return hex;
  }

  public static Color HexToColor (string hex) {
    byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
    byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
    byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
    return new Color32(r, g, b, 255);
  }

}
