﻿'------------------------------------------------------------------------------
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
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("StansGrocery.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &quot;1,&quot;apples&quot;
        '''&quot;1&quot;,&quot;bananas&quot;
        '''&quot;1&quot;,&quot;oranges&quot;
        '''&quot;1&quot;,&quot;strawberrys&quot;
        '''&quot;1&quot;,&quot;rasberrys&quot;
        '''&quot;2&quot;,&quot;carrots&quot;
        '''&quot;2&quot;,&quot;onions&quot;
        '''&quot;2&quot;,&quot;potatoes&quot;
        '''&quot;2&quot;,&quot;green beans&quot;
        '''&quot;2&quot;,&quot;celery&quot;
        '''&quot;3&quot;,&quot;clam chower&quot;
        '''&quot;3&quot;,&quot;potato bacon&quot;
        '''&quot;3&quot;,&quot;cream of chicken&quot;
        '''&quot;3&quot;,&quot;beef stew&quot;
        '''&quot;3&quot;,&quot;baked beans&quot;.
        '''</summary>
        Friend ReadOnly Property Grocery() As String
            Get
                Return ResourceManager.GetString("Grocery", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
