'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class branch_th
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("iEasyPOS.branch_th", GetType(branch_th).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ที่อยู่ 1.
        '''</summary>
        Friend Shared ReadOnly Property Address1() As String
            Get
                Return ResourceManager.GetString("Address1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ที่อยู่ 2.
        '''</summary>
        Friend Shared ReadOnly Property Address2() As String
            Get
                Return ResourceManager.GetString("Address2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to แสดงที่อยู่บนใบเสร็จ.
        '''</summary>
        Friend Shared ReadOnly Property AddressOnReceipt() As String
            Get
                Return ResourceManager.GetString("AddressOnReceipt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ตั้งค่าสาขา.
        '''</summary>
        Friend Shared ReadOnly Property Branch() As String
            Get
                Return ResourceManager.GetString("Branch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to เลขที่สาขา.
        '''</summary>
        Friend Shared ReadOnly Property BranchCode() As String
            Get
                Return ResourceManager.GetString("BranchCode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ชื่อสาขา.
        '''</summary>
        Friend Shared ReadOnly Property BranchName() As String
            Get
                Return ResourceManager.GetString("BranchName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ชื่อบริษัท.
        '''</summary>
        Friend Shared ReadOnly Property CompanyName() As String
            Get
                Return ResourceManager.GetString("CompanyName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ลบข้อมูล.
        '''</summary>
        Friend Shared ReadOnly Property Del() As String
            Get
                Return ResourceManager.GetString("Del", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to แฟกส์.
        '''</summary>
        Friend Shared ReadOnly Property Fax() As String
            Get
                Return ResourceManager.GetString("Fax", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to เพิ่มเติม.
        '''</summary>
        Friend Shared ReadOnly Property More() As String
            Get
                Return ResourceManager.GetString("More", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to โทรศัพท์.
        '''</summary>
        Friend Shared ReadOnly Property PhoneNumber() As String
            Get
                Return ResourceManager.GetString("PhoneNumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to จังหวัด.
        '''</summary>
        Friend Shared ReadOnly Property Provin() As String
            Get
                Return ResourceManager.GetString("Provin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to บันทึก.
        '''</summary>
        Friend Shared ReadOnly Property Save() As String
            Get
                Return ResourceManager.GetString("Save", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to เลขประจำตัวผู้เสียภาษี.
        '''</summary>
        Friend Shared ReadOnly Property TaxID() As String
            Get
                Return ResourceManager.GetString("TaxID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รหัสไปรษณีย์.
        '''</summary>
        Friend Shared ReadOnly Property ZipCode() As String
            Get
                Return ResourceManager.GetString("ZipCode", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
