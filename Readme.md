<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621589/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2297)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyDataSourceWrapper.cs](./CS/MyDataSourceWrapper/MyDataSourceWrapper.cs) (VB: [MyDataSourceWrapper.vb](./VB/MyDataSourceWrapper/MyDataSourceWrapper.vb))
* [MyGridLookupDataSourceHelper.cs](./CS/MyDataSourceWrapper/MyGridLookupDataSourceHelper.cs) (VB: [MyGridLookupDataSourceHelper.vb](./VB/MyDataSourceWrapper/MyGridLookupDataSourceHelper.vb))
* [MyObject.cs](./CS/MyDataSourceWrapper/MyObject.cs) (VB: [MyObject.vb](./VB/MyDataSourceWrapper/MyObject.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to make a Lookup editor function as a regular ComboBox


<p>Starting with version <strong>16.1</strong> we support the <a href="https://documentation.devexpress.com/WindowsForms/116019/Controls-and-Libraries/Editors-and-Simple-Controls/Lookup-Editors/Combobox-Mode-Allow-Entering-New-Values">Combobox Mode</a> for lookup editors such as <strong>LookUpEdit</strong> and <strong>GridLookUpEdit</strong> out of the box. <br><br><strong>For older versions:</strong></p>
<p><br>A Lookup editor is a kind of editors that can only display those values that are present in its dropdown list. Such editor can't display any value in its edit box. When a user types a value in the Lookup editor edit box, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsLookUpEditBase_ProcessNewValuetopic">ProcessNewValue</a> fires. This event allows you to handle this situation and add the typed value to the editor's datasource. In this case, this value won't dissappear when the editor is validated.</p>
<p>However, if you need to have a fixed dropdown list and don't want to change the editor's datasource, this solution is not suitable for you. To overcome this problem, it's necessary to create a custom datasource wrapper. This wrapper will store the last typed value, and that's why the Lookup editor will show this value without any problem. However, this change won't affect a wrapped datasource.</p>
<p>This example is based on the <a href="https://www.devexpress.com/Support/Center/p/E1180">How to create a data source wrapper that adds an empty item to the lookup list</a> example. The only requirement is that your datasource should implement the ITypedList interface. You see that you can modify your original datasource values, and these changes will be automatically displayed in the GridLookUpEdit's datasource. However, changes made within the ProcessNewEvent event handler won't affect your original datasource.</p>

<br/>


