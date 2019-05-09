using System;
using System.Collections;

namespace CalendarSample.Forms.Model
{

    /// <summary>
    /// カレンダ.Model
    /// </summary>
    public class MainWindow : IDisposable
    {

        #region ViewModel.Property

        /// <summary>
        /// 表示Page一覧
        /// </summary>
        public ArrayList PageSources;

        /// <summary>
        /// PageSources.Index
        /// </summary>
        public int SelectedIndex = -1;

        #endregion

        /// <summary>
        /// カレンダ.Model
        /// </summary>
        public MainWindow()
        {

            PageSources = new ArrayList()
            {
                new Pages.View.Calendar()
            };

            SelectedIndex = 0;

        }

        /// <summary>
        /// 終了処理
        /// </summary>
        public void Dispose()
        {

            if (PageSources != null)
            {
                
                foreach (var source in PageSources)
                {

                    if (source is Pages.View.Calendar calendar)
                    {
                        calendar.Dispose();
                    }

                }

                PageSources.Clear();
                PageSources = null;

            }

        }

    }

}
