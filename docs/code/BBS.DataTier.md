<a name='assembly'></a>
# BBS.DataTier

## Contents

- [CustomContextWriter](#T-Casasoft-BBS-DataTier-CustomContextWriter 'Casasoft.BBS.DataTier.CustomContextWriter')
  - [#ctor(providerConfigurationCodeGenerator,annotationCodeGenerator,cSharpHelper)](#M-Casasoft-BBS-DataTier-CustomContextWriter-#ctor-Microsoft-EntityFrameworkCore-Scaffolding-IProviderConfigurationCodeGenerator,Microsoft-EntityFrameworkCore-Design-IAnnotationCodeGenerator,Microsoft-EntityFrameworkCore-Design-ICSharpHelper- 'Casasoft.BBS.DataTier.CustomContextWriter.#ctor(Microsoft.EntityFrameworkCore.Scaffolding.IProviderConfigurationCodeGenerator,Microsoft.EntityFrameworkCore.Design.IAnnotationCodeGenerator,Microsoft.EntityFrameworkCore.Design.ICSharpHelper)')
  - [WriteCode(model,contextName,connectionString,contextNamespace,modelNamespace,useDataAnnotations,suppressConnectionStringWarning)](#M-Casasoft-BBS-DataTier-CustomContextWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IModel,System-String,System-String,System-String,System-String,System-Boolean,System-Boolean- 'Casasoft.BBS.DataTier.CustomContextWriter.WriteCode(Microsoft.EntityFrameworkCore.Metadata.IModel,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean)')
- [CustomEntityWriter](#T-Casasoft-BBS-DataTier-CustomEntityWriter 'Casasoft.BBS.DataTier.CustomEntityWriter')
  - [#ctor(cSharpHelper)](#M-Casasoft-BBS-DataTier-CustomEntityWriter-#ctor-Microsoft-EntityFrameworkCore-Design-ICSharpHelper- 'Casasoft.BBS.DataTier.CustomEntityWriter.#ctor(Microsoft.EntityFrameworkCore.Design.ICSharpHelper)')
  - [WriteCode(type,namespace,useDataAnnotations)](#M-Casasoft-BBS-DataTier-CustomEntityWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IEntityType,System-String,System-Boolean- 'Casasoft.BBS.DataTier.CustomEntityWriter.WriteCode(Microsoft.EntityFrameworkCore.Metadata.IEntityType,System.String,System.Boolean)')
- [CustomHelpers](#T-Casasoft-BBS-DataTier-CustomHelpers 'Casasoft.BBS.DataTier.CustomHelpers')
  - [classSummary](#F-Casasoft-BBS-DataTier-CustomHelpers-classSummary 'Casasoft.BBS.DataTier.CustomHelpers.classSummary')
  - [copyrightNotice](#F-Casasoft-BBS-DataTier-CustomHelpers-copyrightNotice 'Casasoft.BBS.DataTier.CustomHelpers.copyrightNotice')
  - [ppc](#F-Casasoft-BBS-DataTier-CustomHelpers-ppc 'Casasoft.BBS.DataTier.CustomHelpers.ppc')
  - [propertySummary](#F-Casasoft-BBS-DataTier-CustomHelpers-propertySummary 'Casasoft.BBS.DataTier.CustomHelpers.propertySummary')
  - [commentedClass(code,comment)](#M-Casasoft-BBS-DataTier-CustomHelpers-commentedClass-System-String,System-String- 'Casasoft.BBS.DataTier.CustomHelpers.commentedClass(System.String,System.String)')
- [Startup](#T-Casasoft-BBS-DataTier-Startup 'Casasoft.BBS.DataTier.Startup')
  - [ConfigureDesignTimeServices(serviceCollection)](#M-Casasoft-BBS-DataTier-Startup-ConfigureDesignTimeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Casasoft.BBS.DataTier.Startup.ConfigureDesignTimeServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [bbsContext](#T-Casasoft-BBS-DataTier-bbsContext 'Casasoft.BBS.DataTier.bbsContext')
  - [OnConfiguring(optionsBuilder)](#M-Casasoft-BBS-DataTier-bbsContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder- 'Casasoft.BBS.DataTier.bbsContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)')

<a name='T-Casasoft-BBS-DataTier-CustomContextWriter'></a>
## CustomContextWriter `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Inherits and extends DbContext generator

<a name='M-Casasoft-BBS-DataTier-CustomContextWriter-#ctor-Microsoft-EntityFrameworkCore-Scaffolding-IProviderConfigurationCodeGenerator,Microsoft-EntityFrameworkCore-Design-IAnnotationCodeGenerator,Microsoft-EntityFrameworkCore-Design-ICSharpHelper-'></a>
### #ctor(providerConfigurationCodeGenerator,annotationCodeGenerator,cSharpHelper) `constructor`

##### Summary

Default constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| providerConfigurationCodeGenerator | [Microsoft.EntityFrameworkCore.Scaffolding.IProviderConfigurationCodeGenerator](#T-Microsoft-EntityFrameworkCore-Scaffolding-IProviderConfigurationCodeGenerator 'Microsoft.EntityFrameworkCore.Scaffolding.IProviderConfigurationCodeGenerator') |  |
| annotationCodeGenerator | [Microsoft.EntityFrameworkCore.Design.IAnnotationCodeGenerator](#T-Microsoft-EntityFrameworkCore-Design-IAnnotationCodeGenerator 'Microsoft.EntityFrameworkCore.Design.IAnnotationCodeGenerator') |  |
| cSharpHelper | [Microsoft.EntityFrameworkCore.Design.ICSharpHelper](#T-Microsoft-EntityFrameworkCore-Design-ICSharpHelper 'Microsoft.EntityFrameworkCore.Design.ICSharpHelper') |  |

<a name='M-Casasoft-BBS-DataTier-CustomContextWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IModel,System-String,System-String,System-String,System-String,System-Boolean,System-Boolean-'></a>
### WriteCode(model,contextName,connectionString,contextNamespace,modelNamespace,useDataAnnotations,suppressConnectionStringWarning) `method`

##### Summary

Code writer

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Microsoft.EntityFrameworkCore.Metadata.IModel](#T-Microsoft-EntityFrameworkCore-Metadata-IModel 'Microsoft.EntityFrameworkCore.Metadata.IModel') |  |
| contextName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| connectionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| contextNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| modelNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| useDataAnnotations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| suppressConnectionStringWarning | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Casasoft-BBS-DataTier-CustomEntityWriter'></a>
## CustomEntityWriter `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Inherits and extends Entity classes generator

<a name='M-Casasoft-BBS-DataTier-CustomEntityWriter-#ctor-Microsoft-EntityFrameworkCore-Design-ICSharpHelper-'></a>
### #ctor(cSharpHelper) `constructor`

##### Summary

Default constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cSharpHelper | [Microsoft.EntityFrameworkCore.Design.ICSharpHelper](#T-Microsoft-EntityFrameworkCore-Design-ICSharpHelper 'Microsoft.EntityFrameworkCore.Design.ICSharpHelper') |  |

<a name='M-Casasoft-BBS-DataTier-CustomEntityWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IEntityType,System-String,System-Boolean-'></a>
### WriteCode(type,namespace,useDataAnnotations) `method`

##### Summary

Code writer

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [Microsoft.EntityFrameworkCore.Metadata.IEntityType](#T-Microsoft-EntityFrameworkCore-Metadata-IEntityType 'Microsoft.EntityFrameworkCore.Metadata.IEntityType') |  |
| namespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| useDataAnnotations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Casasoft-BBS-DataTier-CustomHelpers'></a>
## CustomHelpers `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Common strings for db scaffolding customization

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-classSummary'></a>
### classSummary `constants`

##### Summary

Class summary comment

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-copyrightNotice'></a>
### copyrightNotice `constants`

##### Summary

copyright notice to add at the top of the file

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-ppc'></a>
### ppc `constants`

##### Summary

class declaration

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-propertySummary'></a>
### propertySummary `constants`

##### Summary

Property summary comment

<a name='M-Casasoft-BBS-DataTier-CustomHelpers-commentedClass-System-String,System-String-'></a>
### commentedClass(code,comment) `method`

##### Summary

Adds comment to class declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | uncommented code |
| comment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | comment to the class |

<a name='T-Casasoft-BBS-DataTier-Startup'></a>
## Startup `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Configures services for db scaffolding

<a name='M-Casasoft-BBS-DataTier-Startup-ConfigureDesignTimeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureDesignTimeServices(serviceCollection) `method`

##### Summary

Configures services for db scaffolding

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceCollection | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-Casasoft-BBS-DataTier-bbsContext'></a>
## bbsContext `type`

##### Namespace

Casasoft.BBS.DataTier

<a name='M-Casasoft-BBS-DataTier-bbsContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder-'></a>
### OnConfiguring(optionsBuilder) `method`

##### Summary

Gets connection string from app.config

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionsBuilder | [Microsoft.EntityFrameworkCore.DbContextOptionsBuilder](#T-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder 'Microsoft.EntityFrameworkCore.DbContextOptionsBuilder') |  |
