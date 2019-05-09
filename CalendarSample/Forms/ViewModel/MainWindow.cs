using AYam.Common.ViewModel;
using System;

namespace CalendarSample.Forms.ViewModel
{

    /// <summary>
    /// カレンダ.ViewModel
    /// </summary>
    public class MainWindow : VMBase, IDisposable
    {

        /// <summary>
        /// Model
        /// </summary>
        private Model.MainWindow _Model;

        #region Property

        /// <summary>
        /// 表示Page
        /// </summary>
        public object PageSource
        {
            get
            {
                if (_Model.SelectedIndex.Equals(-1))
                {
                    return null;
                }
                else
                {
                    return _Model.PageSources[_Model.SelectedIndex];
                }
            }
        }

        #endregion

        /// <summary>
        /// カレンダ.ViewModel
        /// </summary>
        public MainWindow()
        {
            _Model = new Model.MainWindow();
        }

        /// <summary>
        /// 終了処理
        /// </summary>
        public void Dispose()
        {

            if (_Model != null)
            {
                _Model.Dispose();
                _Model = null;
            }

        }

    }
}
