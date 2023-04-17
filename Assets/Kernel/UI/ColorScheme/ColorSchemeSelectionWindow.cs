using System;
using System.Collections.Generic;
using System.Linq;
using Kernel.Extensions;
using Kernel.Gameplay.Color;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Kernel.UI
{
    public class ColorSchemeSelectionWindow : MonoBehaviour
    {
        [Required, SerializeField] private Transform _windowItems;
        [Required, SerializeField] private VerticalLayoutGroup _elementsParent;
        
        [Required, SerializeField] private Mediator _mediator;
        
        private readonly List<ColorSchemeSelectionElement> _elements = new();
        private ColorSchemeSelectionElement _selectedElement;
        private RectTransform _elementsParentRectTransform;

        private void Awake() => _elementsParentRectTransform = _elementsParent.GetComponent<RectTransform>();

        public void AddElement(ColorSchemeSelectionElement element)
        {
            element.Pressed += SelectElement;
            element.transform.SetParent(_elementsParent.transform);
            element.transform.localScale = Vector3.one;
            _elements.Add(element);
            
            _elementsParentRectTransform.sizeDelta = _elementsParentRectTransform.sizeDelta.SetY(CalculateContainerHeight());
        }

        public void SetSelectedColorScheme(ColorSchemeConfiguration colorScheme)
        {
            var element = _elements.First(x => x.ColorScheme.Name == colorScheme.Name);
            SelectElement(element);
        }

        public void Show() => _windowItems.gameObject.SetActive(true);
        public void Hide() => _windowItems.gameObject.SetActive(false);

        private void SelectElement(ColorSchemeSelectionElement element)
        {
            if (_selectedElement.Exists()) 
                _selectedElement.Deselect();

            _selectedElement = element;
            _selectedElement.Select();

            _mediator.SetColorScheme(_selectedElement.ColorScheme);
        }

        private float CalculateContainerHeight()
        {
            var spacing = _elementsParent.spacing;
            var yScale = 0f;
            
            foreach (var element in _elements)
            {
                yScale += element.transform.localScale.y;
                yScale += spacing;
            }

            return yScale;
        }
    }
}