
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.


// ----- DOS Header:
// Magic:                      0x5a4d
// Bytes on last page:         0x0090
// Pages in file:              0x0003
// Relocations:                0x0000
// Size of header (paragraphs):0x0004
// Min extra paragraphs:       0x0000
// Max extra paragraphs:       0xffff
// Initial (relative) SS:      0x0000
// Initial SP:                 0x00b8
// Checksum:                   0x0000
// Initial IP:                 0x0000
// Initial (relative) CS:      0x0000
// File addr. of reloc table:  0x0040
// Overlay number:             0x0000
// OEM identifier:             0x0000
// OEM info:                   0x0000
// File addr. of COFF header:  0x0080
// ----- COFF/PE Headers:
// Signature:                  0x00004550
// ----- COFF Header:
// Machine:                    0x014c
// Number of sections:         0x0003
// Time-date stamp:            0xde0802c5
// Ptr to symbol table:        0x00000000
// Number of symbols:          0x00000000
// Size of optional header:    0x00e0
// Characteristics:            0x2022
// ----- PE Optional Header (32 bit):
// Magic:                          0x010b
// Major linker version:           0x30
// Minor linker version:           0x00
// Size of code:                   0x00000800
// Size of init.data:              0x00000600
// Size of uninit.data:            0x00000000
// Addr. of entry point:           0x00002686
// Base of code:                   0x00002000
// Base of data:                   0x00004000
// Image base:                     0x10000000
// Section alignment:              0x00002000
// File alignment:                 0x00000200
// Major OS version:               0x0004
// Minor OS version:               0x0000
// Major image version:            0x0000
// Minor image version:            0x0000
// Major subsystem version:        0x0004
// Minor subsystem version:        0x0000
// Size of image:                  0x00008000
// Size of headers:                0x00000200
// Checksum:                       0x00000000
// Subsystem:                      0x0003
// DLL characteristics:            0x8560
// Size of stack reserve:          0x00100000
// Size of stack commit:           0x00001000
// Size of heap reserve:           0x00100000
// Size of heap commit:            0x00001000
// Loader flags:                   0x00000000
// Directories:                    0x00000010
// 0x00000000 [0x00000000] address [size] of Export Directory:          
// 0x00002633 [0x0000004f] address [size] of Import Directory:          
// 0x00004000 [0x0000031c] address [size] of Resource Directory:        
// 0x00000000 [0x00000000] address [size] of Exception Directory:       
// 0x00000000 [0x00000000] address [size] of Security Directory:        
// 0x00006000 [0x0000000c] address [size] of Base Relocation Table:     
// 0x00002538 [0x00000054] address [size] of Debug Directory:           
// 0x00000000 [0x00000000] address [size] of Architecture Specific:     
// 0x00000000 [0x00000000] address [size] of Global Pointer:            
// 0x00000000 [0x00000000] address [size] of TLS Directory:             
// 0x00000000 [0x00000000] address [size] of Load Config Directory:     
// 0x00000000 [0x00000000] address [size] of Bound Import Directory:    
// 0x00002000 [0x00000008] address [size] of Import Address Table:      
// 0x00000000 [0x00000000] address [size] of Delay Load IAT:            
// 0x00002008 [0x00000048] address [size] of CLR Header:                


// Image sections:
//              .text
//              0x0000068c Virtual Size
//              0x00002000 Virtual Address
//              0x00000800 Size of Raw Data
//              0x00000200 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x60000020 Characteristics
//                         CNT_CODE
//                         MEM_EXECUTE
//                         MEM_READ

//              .rsrc
//              0x0000031c Virtual Size
//              0x00004000 Virtual Address
//              0x00000400 Size of Raw Data
//              0x00000a00 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x40000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_READ

//              .reloc
//              0x0000000c Virtual Size
//              0x00006000 Virtual Address
//              0x00000200 Size of Raw Data
//              0x00000e00 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x42000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_DISCARDABLE
//                         MEM_READ

// Base Relocation Table
//              0x00002000 Page RVA
//              0x0000000c Block Size
//              0x00000002 Number of Entries
//              Entry 1: Type 0x3 Offset 0x00000688
//              Entry 2: Type 0x0 Offset 0x00000000

// Import Address Table
//     DLL : mscoree.dll
//              0x00002000 Import Address Table
//              0x00002675 Import Name Table
//              0          Time Date Stamp
//              0          Index of First Forwarder Reference
//
//              0x0000  _CorDllMain

// Delay Load Import Address Table
// No data.

// Entry point code:
//FF 25 00 20 00 10 


// ----- CLR Header:
// Header size:                        0x00000048
// Major runtime version:              0x0002
// Minor runtime version:              0x0005
// 0x0000205c [0x000004dc] address [size] of Metadata Directory:        
// Flags:                              0x00000001
// Entry point token:                  0x00000000
// 0x00000000 [0x00000000] address [size] of Resources Directory:       
// 0x00000000 [0x00000000] address [size] of Strong Name Signature:     
// 0x00000000 [0x00000000] address [size] of CodeManager Table:         
// 0x00000000 [0x00000000] address [size] of VTableFixups Directory:    
// 0x00000000 [0x00000000] address [size] of Export Address Table:      
// 0x00000000 [0x00000000] address [size] of Precompile Header:         

// Metadata Header
//    Storage Signature:
//              0x424a5342 Signature
//                  0x0001 Major Version
//                  0x0001 Minor Version
//              0x00000000 Extra Data Offset
//              0x0000000c Version String Length
//              'v4.0.30319' Version String
//    Storage Header:
//                    0x00 Flags
//                  0x0005 Number of Streams
//    Stream 1:
//              0x0000006c Offset
//              0x000001a8 Size
//              '#~' Name
//    Stream 2:
//              0x00000214 Offset
//              0x000001f0 Size
//              '#Strings' Name
//    Stream 3:
//              0x00000404 Offset
//              0x00000004 Size
//              '#US' Name
//    Stream 4:
//              0x00000408 Offset
//              0x00000010 Size
//              '#GUID' Name
//    Stream 5:
//              0x00000418 Offset
//              0x000000c4 Size
//              '#Blob' Name

//    Metadata Stream Header:
//              0x00000000 Reserved
//                    0x02 Major
//                    0x00 Minor
//                    0x00 Heaps
//                    0x01 Rid
//      0x0000000900001547 MaskValid
//      0x000016003301fa00 Sorted

// Code Manager Table:
//  default


// Export Address Table Jumps:
// No data.

// File size            : 4096
// PE header size       : 512 (496 used)    (12.50%)
// PE additional info   : 1051              (25.66%)
// Num.of PE sections   : 3
// CLR header size     : 72                 ( 1.76%)
// CLR meta-data size  : 1244               (30.37%)
// CLR additional info : 0                  ( 0.00%)
// CLR method headers  : 2                  ( 0.05%)
// Managed code         : 8                 ( 0.20%)
// Data                 : 1536              (37.50%)
// Unaccounted          : -329              (-8.03%)

// Num.of PE sections   : 3
//   .text    - 2048
//   .rsrc    - 1024
//   .reloc   - 512

// CLR meta-data size  : 1244
//   Module        -    1 (10 bytes)
//   TypeDef       -    2 (28 bytes)      0 interfaces, 0 explicit layout
//   TypeRef       -   13 (78 bytes)
//   MethodDef     -    2 (28 bytes)      0 abstract, 0 native, 2 bodies
//   MemberRef     -   11 (66 bytes)
//   ParamDef      -    4 (24 bytes)
//   CustomAttribute-   14 (84 bytes)
//   Assembly      -    1 (22 bytes)
//   AssemblyRef   -    1 (20 bytes)
//   Strings       -   494 bytes
//   Blobs         -   196 bytes
//   UserStrings   -     4 bytes
//   Guids         -    16 bytes
//   Uncategorized -   174 bytes

// CLR method headers : 2
//   Num.of method bodies  - 2
//   Num.of fat headers    - 0
//   Num.of tiny headers   - 2

// Managed code : 8
//   Ave method size - 4
// Classes defined in this module:
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Class MyClass                        (public) (abstract) (auto) (ansi) (sealed) 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// ================================= M E T A I N F O ================================================

// ===========================================================
// ScopeName : MyLibrary.dll
// MVID      : {F6708251-65F7-458B-93B0-F35A2D252D62}
// ===========================================================
// Global functions
// -------------------------------------------------------
// 
// Global fields
// -------------------------------------------------------
// 
// Global MemberRefs
// -------------------------------------------------------
// 
// TypeDef #1 (02000002)
// -------------------------------------------------------
// 	TypDefName: MyLibrary.MyClass  (02000002)
// 	Flags     : [Public] [AutoLayout] [Class] [Abstract] [Sealed] [AnsiClass] [BeforeFieldInit]  (00100181)
// 	Extends   : 0100000D [TypeRef] System.Object
// 	Method #1 (06000001) 
// 	-------------------------------------------------------
// 		MethodName: Add (06000001)
// 		Flags     : [Public] [Static] [HideBySig] [ReuseSlot]  (00000096)
// 		RVA       : 0x00002050
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		ReturnType: I4
// 		2 Arguments
// 			Argument #1:  I4
// 			Argument #2:  I4
// 		2 Parameters
// 			(1) ParamToken : (08000001) Name : a flags: [none] (00000000)
// 			(2) ParamToken : (08000002) Name : b flags: [none] (00000000)
// 		CustomAttribute #1 (0c000001)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a000001
// 			CustomAttributeName: System.Runtime.CompilerServices.ExtensionAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #2 (06000002) 
// 	-------------------------------------------------------
// 		MethodName: Sub (06000002)
// 		Flags     : [Public] [Static] [HideBySig] [ReuseSlot]  (00000096)
// 		RVA       : 0x00002055
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		ReturnType: I4
// 		2 Arguments
// 			Argument #1:  I4
// 			Argument #2:  I4
// 		2 Parameters
// 			(1) ParamToken : (08000003) Name : a flags: [none] (00000000)
// 			(2) ParamToken : (08000004) Name : b flags: [none] (00000000)
// 		CustomAttribute #1 (0c00000d)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a000001
// 			CustomAttributeName: System.Runtime.CompilerServices.ExtensionAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	CustomAttribute #1 (0c00000e)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000001
// 		CustomAttributeName: System.Runtime.CompilerServices.ExtensionAttribute :: instance void .ctor()
// 		Length: 4
// 		Value : 01 00 00 00                                      >                <
// 		ctor args: ()
// 
// 
// TypeRef #1 (01000001)
// -------------------------------------------------------
// Token:             0x01000001
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.ExtensionAttribute
// 	MemberRef #1 (0a000001)
// 	-------------------------------------------------------
// 		Member: (0a000001) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// TypeRef #2 (01000002)
// -------------------------------------------------------
// Token:             0x01000002
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.CompilationRelaxationsAttribute
// 	MemberRef #1 (0a000002)
// 	-------------------------------------------------------
// 		Member: (0a000002) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  I4
// 
// TypeRef #3 (01000003)
// -------------------------------------------------------
// Token:             0x01000003
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
// 	MemberRef #1 (0a000003)
// 	-------------------------------------------------------
// 		Member: (0a000003) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// TypeRef #4 (01000004)
// -------------------------------------------------------
// Token:             0x01000004
// ResolutionScope:   0x23000001
// TypeRefName:       System.Diagnostics.DebuggableAttribute
// 	MemberRef #1 (0a000004)
// 	-------------------------------------------------------
// 		Member: (0a000004) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  ValueClass DebuggingModes
// 
// TypeRef #5 (01000005)
// -------------------------------------------------------
// Token:             0x01000005
// ResolutionScope:   0x01000004
// TypeRefName:       DebuggingModes
// 
// TypeRef #6 (01000006)
// -------------------------------------------------------
// Token:             0x01000006
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.Versioning.TargetFrameworkAttribute
// 	MemberRef #1 (0a000005)
// 	-------------------------------------------------------
// 		Member: (0a000005) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #7 (01000007)
// -------------------------------------------------------
// Token:             0x01000007
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyCompanyAttribute
// 	MemberRef #1 (0a000006)
// 	-------------------------------------------------------
// 		Member: (0a000006) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #8 (01000008)
// -------------------------------------------------------
// Token:             0x01000008
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyConfigurationAttribute
// 	MemberRef #1 (0a000007)
// 	-------------------------------------------------------
// 		Member: (0a000007) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #9 (01000009)
// -------------------------------------------------------
// Token:             0x01000009
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyFileVersionAttribute
// 	MemberRef #1 (0a000008)
// 	-------------------------------------------------------
// 		Member: (0a000008) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #10 (0100000a)
// -------------------------------------------------------
// Token:             0x0100000a
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyInformationalVersionAttribute
// 	MemberRef #1 (0a000009)
// 	-------------------------------------------------------
// 		Member: (0a000009) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #11 (0100000b)
// -------------------------------------------------------
// Token:             0x0100000b
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyProductAttribute
// 	MemberRef #1 (0a00000a)
// 	-------------------------------------------------------
// 		Member: (0a00000a) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #12 (0100000c)
// -------------------------------------------------------
// Token:             0x0100000c
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyTitleAttribute
// 	MemberRef #1 (0a00000b)
// 	-------------------------------------------------------
// 		Member: (0a00000b) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #13 (0100000d)
// -------------------------------------------------------
// Token:             0x0100000d
// ResolutionScope:   0x23000001
// TypeRefName:       System.Object
// 
// Assembly
// -------------------------------------------------------
// 	Token: 0x20000001
// 	Name : MyLibrary
// 	Public Key    :
// 	Hash Algorithm : 0x00008004
// 	Version: 1.0.0.0
// 	Major Version: 0x00000001
// 	Minor Version: 0x00000000
// 	Build Number: 0x00000000
// 	Revision Number: 0x00000000
// 	Locale: <null>
// 	Flags : [none] (00000000)
// 	CustomAttribute #1 (0c000002)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000001
// 		CustomAttributeName: System.Runtime.CompilerServices.ExtensionAttribute :: instance void .ctor()
// 		Length: 4
// 		Value : 01 00 00 00                                      >                <
// 		ctor args: ()
// 
// 	CustomAttribute #2 (0c000003)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000002
// 		CustomAttributeName: System.Runtime.CompilerServices.CompilationRelaxationsAttribute :: instance void .ctor(int32)
// 		Length: 8
// 		Value : 01 00 08 00 00 00 00 00                          >                <
// 		ctor args: (8)
// 
// 	CustomAttribute #3 (0c000004)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000003
// 		CustomAttributeName: System.Runtime.CompilerServices.RuntimeCompatibilityAttribute :: instance void .ctor()
// 		Length: 30
// 		Value : 01 00 01 00 54 02 16 57  72 61 70 4e 6f 6e 45 78 >    T  WrapNonEx<
//                       : 63 65 70 74 69 6f 6e 54  68 72 6f 77 73 01       >ceptionThrows   <
// 		ctor args: ()
// 
// 	CustomAttribute #4 (0c000005)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000004
// 		CustomAttributeName: System.Diagnostics.DebuggableAttribute :: instance void .ctor(value class DebuggingModes)
// 		Length: 8
// 		Value : 01 00 07 01 00 00 00 00                          >                <
// 		ctor args: ( <can not decode> )
// 
// 	CustomAttribute #5 (0c000006)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000005
// 		CustomAttributeName: System.Runtime.Versioning.TargetFrameworkAttribute :: instance void .ctor(class System.String)
// 		Length: 53
// 		Value : 01 00 18 2e 4e 45 54 43  6f 72 65 41 70 70 2c 56 >   .NETCoreApp,V<
//                       : 65 72 73 69 6f 6e 3d 76  35 2e 30 01 00 54 0e 14 >ersion=v5.0  T  <
//                       : 46 72 61 6d 65 77 6f 72  6b 44 69 73 70 6c 61 79 >FrameworkDisplay<
//                       : 4e 61 6d 65 00                                   >Name            <
// 		ctor args: (".NETCoreApp,Version=v5.0")
// 
// 	CustomAttribute #6 (0c000007)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000006
// 		CustomAttributeName: System.Reflection.AssemblyCompanyAttribute :: instance void .ctor(class System.String)
// 		Length: 14
// 		Value : 01 00 09 4d 79 4c 69 62  72 61 72 79 00 00       >   MyLibrary    <
// 		ctor args: ("MyLibrary")
// 
// 	CustomAttribute #7 (0c000008)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000007
// 		CustomAttributeName: System.Reflection.AssemblyConfigurationAttribute :: instance void .ctor(class System.String)
// 		Length: 10
// 		Value : 01 00 05 44 65 62 75 67  00 00                   >   Debug        <
// 		ctor args: ("Debug")
// 
// 	CustomAttribute #8 (0c000009)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000008
// 		CustomAttributeName: System.Reflection.AssemblyFileVersionAttribute :: instance void .ctor(class System.String)
// 		Length: 12
// 		Value : 01 00 07 31 2e 30 2e 30  2e 30 00 00             >   1.0.0.0      <
// 		ctor args: ("1.0.0.0")
// 
// 	CustomAttribute #9 (0c00000a)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000009
// 		CustomAttributeName: System.Reflection.AssemblyInformationalVersionAttribute :: instance void .ctor(class System.String)
// 		Length: 10
// 		Value : 01 00 05 31 2e 30 2e 30  00 00                   >   1.0.0        <
// 		ctor args: ("1.0.0")
// 
// 	CustomAttribute #10 (0c00000b)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000a
// 		CustomAttributeName: System.Reflection.AssemblyProductAttribute :: instance void .ctor(class System.String)
// 		Length: 14
// 		Value : 01 00 09 4d 79 4c 69 62  72 61 72 79 00 00       >   MyLibrary    <
// 		ctor args: ("MyLibrary")
// 
// 	CustomAttribute #11 (0c00000c)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000b
// 		CustomAttributeName: System.Reflection.AssemblyTitleAttribute :: instance void .ctor(class System.String)
// 		Length: 14
// 		Value : 01 00 09 4d 79 4c 69 62  72 61 72 79 00 00       >   MyLibrary    <
// 		ctor args: ("MyLibrary")
// 
// 
// AssemblyRef #1 (23000001)
// -------------------------------------------------------
// 	Token: 0x23000001
// 	Public Key or Token: b0 3f 5f 7f 11 d5 0a 3a 
// 	Name: System.Runtime
// 	Version: 5.0.0.0
// 	Major Version: 0x00000005
// 	Minor Version: 0x00000000
// 	Build Number: 0x00000000
// 	Revision Number: 0x00000000
// 	Locale: <null>
// 	HashValue Blob:
// 	Flags: [none] (00000000)
// 
// 
// 
// 
// Coff symbol name overhead:  0
// ===========================================================
// ===========================================================
// ===========================================================
// ================================= END OF METAINFO ================================================


// Metadata version: v4.0.30319
.assembly extern /*23000001*/ System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly /*20000001*/ MyLibrary
{
  .custom /*0C000002:0A000001*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000001*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
  .custom /*0C000003:0A000002*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilationRelaxationsAttribute/*01000002*/::.ctor(int32) /* 0A000002 */ = ( 01 00 08 00 00 00 00 00 ) 
  .custom /*0C000004:0A000003*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute/*01000003*/::.ctor() /* 0A000003 */ = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                                                                                63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom /*0C000005:0A000004*/ instance void [System.Runtime/*23000001*/]System.Diagnostics.DebuggableAttribute/*01000004*/::.ctor(valuetype [System.Runtime/*23000001*/]System.Diagnostics.DebuggableAttribute/*01000004*//DebuggingModes/*01000005*/) /* 0A000004 */ = ( 01 00 07 01 00 00 00 00 ) 

  .custom /*0C000006:0A000005*/ instance void [System.Runtime/*23000001*/]System.Runtime.Versioning.TargetFrameworkAttribute/*01000006*/::.ctor(string) /* 0A000005 */ = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                                                                                           65 72 73 69 6F 6E 3D 76 35 2E 30 01 00 54 0E 14   // ersion=v5.0..T..
                                                                                                                                                                           46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                                                                                           4E 61 6D 65 00 )                                  // Name.
  .custom /*0C000007:0A000006*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyCompanyAttribute/*01000007*/::.ctor(string) /* 0A000006 */ = ( 01 00 09 4D 79 4C 69 62 72 61 72 79 00 00 )       // ...MyLibrary..
  .custom /*0C000008:0A000007*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyConfigurationAttribute/*01000008*/::.ctor(string) /* 0A000007 */ = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom /*0C000009:0A000008*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyFileVersionAttribute/*01000009*/::.ctor(string) /* 0A000008 */ = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom /*0C00000A:0A000009*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyInformationalVersionAttribute/*0100000A*/::.ctor(string) /* 0A000009 */ = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom /*0C00000B:0A00000A*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyProductAttribute/*0100000B*/::.ctor(string) /* 0A00000A */ = ( 01 00 09 4D 79 4C 69 62 72 61 72 79 00 00 )       // ...MyLibrary..
  .custom /*0C00000C:0A00000B*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyTitleAttribute/*0100000C*/::.ctor(string) /* 0A00000B */ = ( 01 00 09 4D 79 4C 69 62 72 61 72 79 00 00 )       // ...MyLibrary..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module MyLibrary.dll
// MVID: {F6708251-65F7-458B-93B0-F35A2D252D62}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x056C0000


// =============== CLASS MEMBERS DECLARATION ===================

.class /*02000002*/ public abstract auto ansi sealed beforefieldinit MyLibrary.MyClass
       extends [System.Runtime/*23000001*/]System.Object/*0100000D*/
{
  .custom /*0C00000E:0A000001*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000001*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
  .method /*06000001*/ public hidebysig static 
          int32  Add(int32 a,
                     int32 b) cil managed
  // SIG: 00 02 08 08 08
  {
    .custom /*0C000001:0A000001*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000001*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2050
    // Code size       4 (0x4)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 58   |                  */ add
    IL_0003:  /* 2A   |                  */ ret
  } // end of method MyClass::Add

  .method /*06000002*/ public hidebysig static 
          int32  Sub(int32 a,
                     int32 b) cil managed
  // SIG: 00 02 08 08 08
  {
    .custom /*0C00000D:0A000001*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000001*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2055
    // Code size       4 (0x4)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 59   |                  */ sub
    IL_0003:  /* 2A   |                  */ ret
  } // end of method MyClass::Sub

} // end of class MyLibrary.MyClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MyLibrary.res
