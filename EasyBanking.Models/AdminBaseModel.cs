using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace EasyBanking.Models
{
	public class AdminBaseModel
	{
		private bool? _isNewRecord;

		public virtual bool Deleted { get; set; }

	
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public virtual Guid Id { get; set; }

	
		[NotMapped]
		[JsonIgnore]
		public bool IsNewRecord
		{
			get
			{
				if (_isNewRecord == null)
					return Id == Guid.Empty;

				return _isNewRecord.Value;
			}
			set { _isNewRecord = value; }
		}
	}
}
