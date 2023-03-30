#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
179,
185,
186,
187,
188,
189,
190,
191,
192,
195,
196,
289,
290,
292,
320,
321,
322,
342,
343,
344,
345,
422,
423,
424,
427,
460,
461,
463,
465,
467,
469,
474,
482,
483,
484,
485,
486,
487,
488,
489,
490,
623,
631,
634,
636,
641,
642,
644,
645,
649,
650,
652,
653,
656,
657,
658,
661,
663,
666,
668,
670,
737,
739,
741,
750,
751,
752,
754,
760,
761,
762,
763,
764,
772,
773,
774,
778,
779,
781,
783,
977,
1150,
1151,
5556,
5557,
5559,
5560,
5561,
5562,
5563,
5565,
5567,
5569,
5570,
5579,
5581,
5585,
5586,
5588,
5590,
5592,
5603,
5612,
5613,
5615,
5616,
5617,
5618,
5619,
5621,
5623,
6592,
6596,
6598,
6599,
6600,
6601,
6735,
6736,
6737,
6738,
6758,
6759,
6760,
6762,
6802,
6853,
6855,
6866,
6867,
6868,
7237,
7240,
7241,
7271,
7292,
7298,
7305,
7315,
7319,
7396,
7398,
7411,
7413,
7414,
7415,
7422,
7435,
7455,
7456,
7464,
7466,
7473,
7474,
7477,
7479,
7484,
7490,
7491,
7498,
7500,
7512,
7515,
7516,
7517,
7528,
7537,
7543,
7544,
7545,
7547,
7548,
7566,
7568,
7582,
7605,
7606,
7626,
7656,
7657,
8045,
8046,
8187,
8422,
8423,
8429,
8430,
8431,
8436,
8497,
8803,
8804,
9702,
9723,
9730,
9732,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_ModF (double,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyExtensions_ApplyUpdate (int,int,int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 179,
ves_icall_System_Array_InternalCreate,
// token 185,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 186,
ves_icall_System_Array_CanChangePrimitive,
// token 187,
ves_icall_System_Array_FastCopy_raw,
// token 188,
ves_icall_System_Array_GetLength_raw,
// token 189,
ves_icall_System_Array_GetLowerBound_raw,
// token 190,
ves_icall_System_Array_GetGenericValue_icall,
// token 191,
ves_icall_System_Array_GetValueImpl_raw,
// token 192,
ves_icall_System_Array_SetGenericValue_icall,
// token 195,
ves_icall_System_Array_SetValueImpl_raw,
// token 196,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 289,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 290,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 292,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 320,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 321,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 322,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 342,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 343,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 344,
ves_icall_System_Enum_InternalGetCorElementType,
// token 345,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 422,
ves_icall_System_Environment_get_ProcessorCount,
// token 423,
ves_icall_System_Environment_get_TickCount,
// token 424,
ves_icall_System_Environment_get_TickCount64,
// token 427,
ves_icall_System_Environment_FailFast_raw,
// token 460,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 461,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 463,
ves_icall_System_GC_SuppressFinalize_raw,
// token 465,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 467,
ves_icall_System_GC_GetGCMemoryInfo,
// token 469,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 474,
ves_icall_System_Object_MemberwiseClone_raw,
// token 482,
ves_icall_System_Math_Ceiling,
// token 483,
ves_icall_System_Math_Cos,
// token 484,
ves_icall_System_Math_Floor,
// token 485,
ves_icall_System_Math_Log10,
// token 486,
ves_icall_System_Math_Pow,
// token 487,
ves_icall_System_Math_Sin,
// token 488,
ves_icall_System_Math_Sqrt,
// token 489,
ves_icall_System_Math_Tan,
// token 490,
ves_icall_System_Math_ModF,
// token 623,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 631,
ves_icall_RuntimeType_make_array_type_raw,
// token 634,
ves_icall_RuntimeType_make_byref_type_raw,
// token 636,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 641,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 642,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 644,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 645,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 649,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 650,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 652,
ves_icall_System_RuntimeType_getFullName_raw,
// token 653,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 656,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 657,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 658,
ves_icall_RuntimeType_GetFields_native_raw,
// token 661,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 663,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 666,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 668,
ves_icall_RuntimeType_GetName_raw,
// token 670,
ves_icall_RuntimeType_GetNamespace_raw,
// token 737,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 739,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 741,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 750,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 751,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 752,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 754,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 760,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 761,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 762,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 763,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 764,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 772,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 773,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 774,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 778,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 779,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 781,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 783,
ves_icall_System_String_FastAllocateString_raw,
// token 977,
ves_icall_System_Type_internal_from_handle_raw,
// token 1150,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1151,
ves_icall_System_ValueType_Equals_raw,
// token 5556,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 5557,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 5559,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 5560,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 5561,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 5562,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 5563,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 5565,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 5567,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 5569,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 5570,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 5579,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 5581,
mono_monitor_exit_icall_raw,
// token 5585,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 5586,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 5588,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 5590,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 5592,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 5603,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 5612,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 5613,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 5615,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 5616,
ves_icall_System_Threading_Thread_GetState_raw,
// token 5617,
ves_icall_System_Threading_Thread_SetState_raw,
// token 5618,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 5619,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 5621,
ves_icall_System_Threading_Thread_YieldInternal,
// token 5623,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 6592,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 6596,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 6598,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 6599,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 6600,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 6601,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 6735,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 6736,
ves_icall_System_GCHandle_InternalFree_raw,
// token 6737,
ves_icall_System_GCHandle_InternalGet_raw,
// token 6738,
ves_icall_System_GCHandle_InternalSet_raw,
// token 6758,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 6759,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 6760,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 6762,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 6802,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 6853,
mono_object_hash_icall_raw,
// token 6855,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 6866,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 6867,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 6868,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 7237,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 7240,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 7241,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 7271,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 7292,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 7298,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 7305,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 7315,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 7319,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 7396,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 7398,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 7411,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 7413,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 7414,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 7415,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 7422,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 7435,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 7455,
ves_icall_reflection_get_token_raw,
// token 7456,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 7464,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 7466,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 7473,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 7474,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 7477,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 7479,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 7484,
ves_icall_reflection_get_token_raw,
// token 7490,
ves_icall_get_method_info_raw,
// token 7491,
ves_icall_get_method_attributes,
// token 7498,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 7500,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 7512,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 7515,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 7516,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 7517,
ves_icall_reflection_get_token_raw,
// token 7528,
ves_icall_InternalInvoke_raw,
// token 7537,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 7543,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 7544,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 7545,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 7547,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 7548,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 7566,
ves_icall_InvokeClassConstructor_raw,
// token 7568,
ves_icall_InternalInvoke_raw,
// token 7582,
ves_icall_reflection_get_token_raw,
// token 7605,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 7606,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 7626,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 7656,
ves_icall_reflection_get_token_raw,
// token 7657,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 8045,
ves_icall_AssemblyExtensions_ApplyUpdate,
// token 8046,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 8187,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 8422,
ves_icall_ModuleBuilder_basic_init_raw,
// token 8423,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 8429,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 8430,
ves_icall_ModuleBuilder_getToken_raw,
// token 8431,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 8436,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 8497,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 8803,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 8804,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 9702,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 9723,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 9730,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 9732,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
};
