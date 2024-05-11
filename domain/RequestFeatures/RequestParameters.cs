using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.RequestFeatures
{
	public class RequestParameters
	{
		const int maxPageSize = 36;
		public int PageNumber { get; set; } = 1;
		private int _pageSize = 12;
		public int PageSize { get { return _pageSize; } set { _pageSize = value > maxPageSize ? maxPageSize : value; } }
    }
}
