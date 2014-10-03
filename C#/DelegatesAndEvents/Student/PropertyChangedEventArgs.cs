using System;

public class PropertyChangedEventArgs : EventArgs
{
    private string propertyName;
    private dynamic newValue;
    private dynamic oldValue;
    public string PropertyName { get; set; }
    public dynamic OldValue { get; set; }
    public dynamic NewValue { get; set; }

    public PropertyChangedEventArgs(string propertyName, dynamic oldValue, dynamic newValue)
    {
        this.PropertyName = propertyName;
        this.OldValue = oldValue;
        this.NewValue = newValue;
    }
}
