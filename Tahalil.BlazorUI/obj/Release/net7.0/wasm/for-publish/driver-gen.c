#include <mono/jit/jit.h>
extern void *mono_aot_module_Blazored_LocalStorage_info;
extern void *mono_aot_module_Blazored_Toast_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Authorization_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Components_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Components_Authorization_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Components_Forms_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Components_Web_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Components_WebAssembly_info;
extern void *mono_aot_module_Microsoft_AspNetCore_Metadata_info;
extern void *mono_aot_module_Microsoft_Extensions_Configuration_info;
extern void *mono_aot_module_Microsoft_Extensions_Configuration_Abstractions_info;
extern void *mono_aot_module_Microsoft_Extensions_Configuration_Json_info;
extern void *mono_aot_module_Microsoft_Extensions_DependencyInjection_info;
extern void *mono_aot_module_Microsoft_Extensions_DependencyInjection_Abstractions_info;
extern void *mono_aot_module_Microsoft_Extensions_Logging_info;
extern void *mono_aot_module_Microsoft_Extensions_Logging_Abstractions_info;
extern void *mono_aot_module_Microsoft_Extensions_Options_info;
extern void *mono_aot_module_Microsoft_Extensions_Primitives_info;
extern void *mono_aot_module_Microsoft_JSInterop_info;
extern void *mono_aot_module_MudBlazor_info;
extern void *mono_aot_module_Tahalil_Models_info;
extern void *mono_aot_module_Tahalil_BlazorUI_info;
extern void *mono_aot_module_System_Collections_Concurrent_info;
extern void *mono_aot_module_System_Collections_info;
extern void *mono_aot_module_System_ComponentModel_Annotations_info;
extern void *mono_aot_module_System_ComponentModel_Primitives_info;
extern void *mono_aot_module_System_ComponentModel_TypeConverter_info;
extern void *mono_aot_module_System_ComponentModel_info;
extern void *mono_aot_module_System_Console_info;
extern void *mono_aot_module_System_Linq_Expressions_info;
extern void *mono_aot_module_System_Linq_info;
extern void *mono_aot_module_System_Memory_info;
extern void *mono_aot_module_System_Net_Http_Json_info;
extern void *mono_aot_module_System_Net_Http_info;
extern void *mono_aot_module_System_Net_Primitives_info;
extern void *mono_aot_module_System_ObjectModel_info;
extern void *mono_aot_module_System_Private_Uri_info;
extern void *mono_aot_module_System_Runtime_InteropServices_JavaScript_info;
extern void *mono_aot_module_System_Runtime_info;
extern void *mono_aot_module_System_Security_Claims_info;
extern void *mono_aot_module_System_Text_Encodings_Web_info;
extern void *mono_aot_module_System_Text_Json_info;
extern void *mono_aot_module_System_Text_RegularExpressions_info;
extern void *mono_aot_module_System_Threading_info;
extern void *mono_aot_module_System_info;
extern void *mono_aot_module_System_Private_CoreLib_info;
void register_aot_modules ()
{
	mono_aot_register_module (mono_aot_module_Blazored_LocalStorage_info);
	mono_aot_register_module (mono_aot_module_Blazored_Toast_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Authorization_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Components_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Components_Authorization_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Components_Forms_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Components_Web_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Components_WebAssembly_info);
	mono_aot_register_module (mono_aot_module_Microsoft_AspNetCore_Metadata_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Configuration_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Configuration_Abstractions_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Configuration_Json_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_DependencyInjection_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_DependencyInjection_Abstractions_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Logging_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Logging_Abstractions_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Options_info);
	mono_aot_register_module (mono_aot_module_Microsoft_Extensions_Primitives_info);
	mono_aot_register_module (mono_aot_module_Microsoft_JSInterop_info);
	mono_aot_register_module (mono_aot_module_MudBlazor_info);
	mono_aot_register_module (mono_aot_module_Tahalil_Models_info);
	mono_aot_register_module (mono_aot_module_Tahalil_BlazorUI_info);
	mono_aot_register_module (mono_aot_module_System_Collections_Concurrent_info);
	mono_aot_register_module (mono_aot_module_System_Collections_info);
	mono_aot_register_module (mono_aot_module_System_ComponentModel_Annotations_info);
	mono_aot_register_module (mono_aot_module_System_ComponentModel_Primitives_info);
	mono_aot_register_module (mono_aot_module_System_ComponentModel_TypeConverter_info);
	mono_aot_register_module (mono_aot_module_System_ComponentModel_info);
	mono_aot_register_module (mono_aot_module_System_Console_info);
	mono_aot_register_module (mono_aot_module_System_Linq_Expressions_info);
	mono_aot_register_module (mono_aot_module_System_Linq_info);
	mono_aot_register_module (mono_aot_module_System_Memory_info);
	mono_aot_register_module (mono_aot_module_System_Net_Http_Json_info);
	mono_aot_register_module (mono_aot_module_System_Net_Http_info);
	mono_aot_register_module (mono_aot_module_System_Net_Primitives_info);
	mono_aot_register_module (mono_aot_module_System_ObjectModel_info);
	mono_aot_register_module (mono_aot_module_System_Private_Uri_info);
	mono_aot_register_module (mono_aot_module_System_Runtime_InteropServices_JavaScript_info);
	mono_aot_register_module (mono_aot_module_System_Runtime_info);
	mono_aot_register_module (mono_aot_module_System_Security_Claims_info);
	mono_aot_register_module (mono_aot_module_System_Text_Encodings_Web_info);
	mono_aot_register_module (mono_aot_module_System_Text_Json_info);
	mono_aot_register_module (mono_aot_module_System_Text_RegularExpressions_info);
	mono_aot_register_module (mono_aot_module_System_Threading_info);
	mono_aot_register_module (mono_aot_module_System_info);
	mono_aot_register_module (mono_aot_module_System_Private_CoreLib_info);
}
#define EE_MODE_LLVMONLY_INTERP 1