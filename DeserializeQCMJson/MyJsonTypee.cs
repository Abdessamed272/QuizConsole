class MyJsonType
{
    public string MyStringProperty { get; set; }
    public int MyIntegerProperty { get; set; }
    public MyJsonSubDocumentType MySubDocument { get; set; }
    public List<int> MyListProperty { get; set; }
}
class MyJsonSubDocumentType
{
    public string SubDocumentProperty { get; set; }
}