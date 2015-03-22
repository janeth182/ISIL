
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.17929
//  (c) Microsoft Corporation. Reservados todos los derechos.



// Metadata version: v2.0.50727
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern MyCodeLibrary
{
  .ver 1:0:0:0
}
.assembly simpleTypeClient
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module simpleTypeClient.exe
// MVID: {1652F0CF-8419-4767-B618-5D7923C3C081}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x003D0000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit MyClientApp.MyApp
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  call       void [MyCodeLibrary]MyCodeLibrary.SimpleType::DisplayEnvironment()
    IL_0006:  nop
    IL_0007:  call       string [mscorlib]System.Console::ReadLine()
    IL_000c:  pop
    IL_000d:  ret
  } // end of method MyApp::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method MyApp::.ctor

} // end of class MyClientApp.MyApp


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// ADVERTENCIA: se ha creado el archivo de recursos de Win32 C:\Users\Alumno-CT\Desktop\il.res
