using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;

namespace walnut.form.surgery.privilege
{
    public partial class PrivilegeCard : UserControl
    {
        /// <summary>
        /// 表数据
        /// </summary>
        private List<ListItem> data;

        public PrivilegeCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置全选框的值
        /// </summary>
        private void setSelectAll()
        {
            foreach (var item in this.data)
            {
                if (!item.selected)
                {
                    this.cbx.Checked = false;
                    return;
                }
            }
            this.cbx.Checked = true;
        }

        /// <summary>
        /// 批量设置勾选框
        /// </summary>
        /// <param name="selected"></param>
        private void setAllSelect(Boolean selected)
        {
            for (var i = 0; i < this.fpSheet.Rows.Count; i++)
            {
                fpSheet.Cells[i, 0].Value = selected;
            }
        }

        private void fpLeft_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            // 控件校验
            if (!(sender is FpSpread))
            {
                return;
            }

            // 锚定表单
            var fpSheet = (sender as FpSpread).Sheets[0];
            var column = fpSheet.Columns[e.Column];
            if (!(column.CellType is CheckBoxCellType))
            {
                return;
            }

            // 执行反转操作
            var cell = fpSheet.Cells[e.Row, e.Column];
            if (cell.Value == null)
            {
                cell.Value = false;
            }
            cell.Value = !((Boolean)cell.Value);

            // 全选校验
            this.setSelectAll();
        }

        private void cbx_Click(object sender, EventArgs e)
        {
            // 控件校验
            if (!(sender is CheckBox))
            {
                return;
            }
            var cbx = (CheckBox)sender;

            if (cbx.Checked)
            {
                this.setAllSelect(true);
            }
            else
            {
                this.setAllSelect(false);
            }
        }

        /// <summary>
        /// 容器标题
        /// </summary>
        public String header
        {
            get
            {
                return gpx.Text;
            }
            set
            {
                gpx.Text = value;
            }
        }

        /// <summary>
        /// 从json字符串中提取数据
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="selected"></param>
        public void setData(List<ListItem> data)
        {
            // 记录列宽的设计值
            List<float> frame = new List<float>();
            for (var i = 0; i < this.fpSheet.ColumnCount; i++)
            {
                frame.Add(this.fpSheet.Columns[i].Width);
            }

            // 保存数据
            this.data = data;

            // 设置数据源
            this.fpSheet.DataSource = this.data;

            // 重置列宽
            for (var i = 0; i < frame.Count; i++)
            {
                this.fpSheet.Columns[i].Width = frame[i];
            }

            // 设置全选框
            this.setSelectAll();
        }

        /// <summary>
        /// 获取选中的ICD编码列表
        /// </summary>
        /// <returns></returns>
        public List<String> getSelectedData()
        {
            var result = new List<String>();
            this.data.ForEach(x =>
            {
                if (x.selected) result.Add(x.icdCode);
            });
            return result;
        }
    }

    /// <summary>
    /// 定义数据节点
    /// </summary>
    public class ListItem
    {
        /// <summary>
        /// 是否选中
        /// </summary>
        public Boolean selected { get; set; } = false;

        /// <summary>
        /// ICD编码
        /// </summary>
        public String icdCode { get; set; }

        /// <summary>
        /// ICD名称
        /// </summary>
        public String icdName { get; set; }
    }
}
