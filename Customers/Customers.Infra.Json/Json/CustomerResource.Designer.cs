﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Customers.Infra.Json.Json {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CustomerResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomerResource() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Customers.Infra.Json.Json.CustomerResource", typeof(CustomerResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///  &quot;clientes&quot;: [
        ///    {
        ///      &quot;id&quot;: &quot;1&quot;,
        ///      &quot;nome&quot;: &quot;Maria Sousa&quot;,
        ///      &quot;cpf&quot;: &quot;258.851.854-74&quot;,
        ///      &quot;salario&quot;: &quot;2500.77&quot;
        ///    },
        ///    {
        ///      &quot;id&quot;: &quot;2&quot;,
        ///      &quot;nome&quot;: &quot;Jose Santos&quot;,
        ///      &quot;cpf&quot;: &quot;358.800.700-01&quot;,
        ///      &quot;salario&quot;: &quot;1851.88&quot;
        ///    },
        ///    {
        ///      &quot;id&quot;: &quot;3&quot;,
        ///      &quot;nome&quot;: &quot;Miguel Castro Silva&quot;,
        ///      &quot;cpf&quot;: &quot;269.855.888-51&quot;,
        ///      &quot;salario&quot;: &quot;3854.21&quot;
        ///    },
        ///    {
        ///      &quot;id&quot;: &quot;4&quot;,
        ///      &quot;nome&quot;: &quot;Amanda Gasper Libero&quot;,
        ///      &quot;cpf&quot;: &quot;258.587.854-55&quot;,
        ///      &quot;salario&quot;: &quot;8 [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string Customers {
            get {
                return ResourceManager.GetString("Customers", resourceCulture);
            }
        }
    }
}