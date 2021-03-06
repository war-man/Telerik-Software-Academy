//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Telerik_TestStudio_Solution
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : https://github.com/ 
        /// </summary>
        public GitHubWhereSoftwareIsPage GitHubWhereSoftwareIs
        {
            get
            {
                return new GitHubWhereSoftwareIsPage("https://github.com/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://github.com/login 
        /// </summary>
        public SignInGitHubPage SignInGitHub
        {
            get
            {
                return new SignInGitHubPage("https://github.com/login", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://github.com/new 
        /// </summary>
        public CreateANewRepositoryPage CreateANewRepository
        {
            get
            {
                return new CreateANewRepositoryPage("https://github.com/new", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://github.com/qatrack2015/QATrack 
        /// </summary>
        public Qatrack2015QATrackPage Qatrack2015QATrack
        {
            get
            {
                return new Qatrack2015QATrackPage("https://github.com/qatrack2015/QATrack", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://github.com/qatrack2015/1 
        /// </summary>
        public Qatrack20151Page Qatrack20151
        {
            get
            {
                return new Qatrack20151Page("https://github.com/qatrack2015/1", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://github.com/qatrack2015/1/tree/test 
        /// </summary>
        public Qatrack20151AtTestPage Qatrack20151AtTest
        {
            get
            {
                return new Qatrack20151AtTestPage("https://github.com/qatrack2015/1/tree/test", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://github.com/qatrack2015/1/new/test 
        /// </summary>
        public NewFilePage NewFile
        {
            get
            {
                return new NewFilePage("https://github.com/qatrack2015/1/new/test", _manager.ActiveBrowser.Find);
            }
        }
        public class GitHubWhereSoftwareIsPage : HtmlPage
        {
            public GitHubWhereSoftwareIsPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [href 'Exact' /login] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor SignInLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("href=/login", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'StartsWith' Create a reposi]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor CreateALink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("TextContent=^Create a reposi", "tagname=a");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression SignInLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("href=/login", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CreateALink = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Create a reposi", "tagname=a");
            }
        }
        public class SignInGitHubPage : HtmlPage
        {
            public SignInGitHubPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' login_field] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText LoginFieldText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=login_field", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' password] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword PasswordPassword
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("id=password", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' commit] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit CommitSubmit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("name=commit", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression LoginFieldText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=login_field", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswordPassword = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=password", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CommitSubmit = new ArtOfTest.WebAii.Core.HtmlFindExpression("name=commit", "tagname=input");
            }
        }
        public class CreateANewRepositoryPage : HtmlPage
        {
            public CreateANewRepositoryPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' html:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl HtmlTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TagIndex=html:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' repository_name] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText RepositoryNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=repository_name", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' repository_auto_init] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox RepositoryAutoInitCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=repository_auto_init", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'StartsWith' Create reposito]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton CreateButtonTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("TextContent=^Create reposito", "tagname=button");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression HtmlTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=html:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RepositoryNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=repository_name", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RepositoryAutoInitCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=repository_auto_init", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CreateButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Create reposito", "tagname=button");
            }
        }
        public class Qatrack2015QATrackPage : HtmlPage
        {
            public Qatrack2015QATrackPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv JsRepoPjaxContainerDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=js-repo-pjax-container", "tagname=div");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression JsRepoPjaxContainerDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "tagname=div");
            }
        }
        public class Qatrack20151Page : HtmlPage
        {
            public Qatrack20151Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [href 'Exact' /qatrack2015/1/commits/master] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor CommitLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("href=/qatrack2015/1/commits/master", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][TagIndex 'Exact' button:11]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton MasterBUTTONTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("id=js-repo-pjax-container", "|", "TagIndex=button:11");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][tagIndex 'Exact' span:39]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan x1Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=js-repo-pjax-container", "|", "tagIndex=span:39");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' context-commitish-filter-field] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContextCommitishFilterFieldText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=context-commitish-filter-field");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' body:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl BODYTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TagIndex=body:0");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression CommitLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("href=/qatrack2015/1/commits/master", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MasterBUTTONTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "TagIndex=button:11");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x1Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "tagIndex=span:39");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContextCommitishFilterFieldText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=context-commitish-filter-field");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BODYTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=body:0");
            }
        }
        public class Qatrack20151AtTestPage : HtmlPage
        {
            public Qatrack20151AtTestPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' New file]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton NewFileBUTTONTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "TextContent=New file");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][tagIndex 'Exact' span:84]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=js-repo-pjax-container", "|", "tagIndex=span:84");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' 5a105e8b9d40e1329780d62ea2265d8a-d00491fd7e5bb6fa28c517a0bb32b8b506539d4d] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor x5a105e8b9d40e1329780d62ea2265d8aD00491fd7e5bb6fa28c517a0bb32b8b506539d4dLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=5a105e8b9d40e1329780d62ea2265d8a-d00491fd7e5bb6fa28c517a0bb32b8b506539d4d", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][tagIndex 'Exact' td:11]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell TableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("id=js-repo-pjax-container", "|", "tagIndex=td:11");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ad0234829205b9033196ba818f7a872b-9daeafb9864cf43055ae93beb0afd6c7d144bfa4] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor Ad0234829205b9033196ba818f7a872b9daeafb9864cf43055ae93beb0afd6c7d144bfa4Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=ad0234829205b9033196ba818f7a872b-9daeafb9864cf43055ae93beb0afd6c7d144bfa4", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][tagIndex 'Exact' td:15]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell TableCell0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("id=js-repo-pjax-container", "|", "tagIndex=td:15");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' 8ad8757baa8564dc136c1e07507f4a98-9daeafb9864cf43055ae93beb0afd6c7d144bfa4] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor x8ad8757baa8564dc136c1e07507f4a989daeafb9864cf43055ae93beb0afd6c7d144bfa4Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=8ad8757baa8564dc136c1e07507f4a98-9daeafb9864cf43055ae93beb0afd6c7d144bfa4", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'Exact' 2]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan x2Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("TextContent=2", "tagname=span");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'Exact' 4]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan x4Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("TextContent=4", "tagname=span");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression NewFileBUTTONTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "TextContent=New file");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "tagIndex=span:84");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x5a105e8b9d40e1329780d62ea2265d8aD00491fd7e5bb6fa28c517a0bb32b8b506539d4dLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=5a105e8b9d40e1329780d62ea2265d8a-d00491fd7e5bb6fa28c517a0bb32b8b506539d4d", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "tagIndex=td:11");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Ad0234829205b9033196ba818f7a872b9daeafb9864cf43055ae93beb0afd6c7d144bfa4Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=ad0234829205b9033196ba818f7a872b-9daeafb9864cf43055ae93beb0afd6c7d144bfa4", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TableCell0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "tagIndex=td:15");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x8ad8757baa8564dc136c1e07507f4a989daeafb9864cf43055ae93beb0afd6c7d144bfa4Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=8ad8757baa8564dc136c1e07507f4a98-9daeafb9864cf43055ae93beb0afd6c7d144bfa4", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x2Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=2", "tagname=span");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x4Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=4", "tagname=span");
            }
        }
        public class NewFilePage : HtmlPage
        {
            public NewFilePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' filename] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText FilenameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "name=filename");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][TagIndex 'Exact' div:324]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv Div
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=js-repo-pjax-container", "|", "TagIndex=div:324");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' js-repo-pjax-container][TagIndex 'Exact' textarea:1]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTextArea TextArea
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTextArea>("id=js-repo-pjax-container", "|", "TagIndex=textarea:1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' submit-file] AND [tagname 'Exact' button]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton SubmitFileBUTTONTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "id=submit-file");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression FilenameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "name=filename");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "TagIndex=div:324");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TextArea = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=js-repo-pjax-container", "|", "TagIndex=textarea:1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SubmitFileBUTTONTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "id=submit-file");
            }
        }
    }
    public class Applications
    {
        private Manager _manager;
        public Applications(Manager manager)
        {
            _manager = manager;
        }
    }
}
