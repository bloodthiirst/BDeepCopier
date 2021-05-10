# BDeepCopier

BDeepCopier is a lightweight deep-copy api to , well , make deep copies of objects

## Features

- Heavily use of caching and runtime delegate magic, so after the first use you will basically be running reflection-free code based on delegates
- Ability to override copying behaviour with the use special attributes and even creating your own override behaviour
- supports recusive referencing
- 
## Usage

```csharp
    private class BClass
    {
        public int id;
        public int Age { get; set; }
        public string Name { get; set; }
    }

    // this gets the copier if it's cached or creates a new one and returns it
    // in case of creation this might be bottle neck , so consider pre-caching your copiers :)
    BCopier<BClass> instanceCopier = BDeepCopy.GetCopier<BClass>();
    
    BClass original = new BClass()
        {
            id = 69,
            Age = 23,
            Name = "Bloodthirst"
        };
    
    // that's it , now you have a deep copy
    BClass copy = instanceCopier.Copy(original);
```

## Contributing
In case of a bug , please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
