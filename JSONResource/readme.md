## Usage


````csharp
  public class Simulation : MonoBehaviour {

    // Complete this reference in Unity's editor, or through
    // scripting
    public JSONResourceLoader resourceLoader;

    void Awake () {

      // Add an event handler when done laoding the JSON
      resourceLoader.OnDoneLoading += OnDoneResourceLoading;

      // Start loading
      resourceLoader.Load(Application.streamingAssetsPath);
    }

    // Define resources that inherit JSONResource
    // After loading the json, you can do something like:
    void OnDoneResourceLoading () {
      var resource = new Resource("name");
    }

  }
````

````csharp
  // Example Resource model
  using UnityEngine;
  using System.Collections;

  public class Item : JSONResource {

    public Item (string _key) : base("Item", _key) {}

    public string someProp { get { return sourceData["some_prop"].Value; }}
    public string somePropInt { get { return sourceData["some_prop_int"].AsInt; }}

  }


````