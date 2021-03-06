﻿using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using CodeNav.Properties;

namespace CodeNav.Models
{
    public class CodeDocumentViewModel : PropertyChangedBase
    {
        public CodeDocumentViewModel()
        {
            _codeDocument = new List<CodeItem>();
        }

        private List<CodeItem> _codeDocument;
        public List<CodeItem> CodeDocument {
            get
            {
                return _codeDocument;
            }
            set
            {
                _codeDocument = value;
                NotifyOfPropertyChange();
            }
        }

        public bool ShowFilterToolbar => Settings.Default.ShowFilterToolbar;

        public Visibility ShowFilterToolbarVisibility => Settings.Default.ShowFilterToolbar
            ? Visibility.Visible
            : Visibility.Collapsed;
    }
}
