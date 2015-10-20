using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models;

namespace OpenPluginFolder
{
    [Export(typeof(IPlugin))]
    [ExportMetadata("Title", "OpenPluginFolder")]
    [ExportMetadata("Description", "プラグインフォルダを開くプラグイン")]
    [ExportMetadata("Version", "1.0.0")]
    [ExportMetadata("Author", "@Thiran")]
    [ExportMetadata("Guid", "74659A1A-B252-4612-955C-A419F6E0D183")]
    class OpenPluginFolder : IPlugin
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public void Plugin()
        {
        }

        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
