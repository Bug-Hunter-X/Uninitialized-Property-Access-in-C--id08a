# Uninitialized Property Access in C#

This example showcases a common yet subtle error in C#: accessing a property before assigning it a value.

The `UninitializedProperty.cs` file demonstrates this problem.  The `MyProperty` is not given an explicit value, and yet is read in `MyMethod`.  The output is unpredictable - sometimes it might print the default value (0 for int), but in other scenarios, or if certain optimizations are done, the results might be completely unexpected, and may even throw exceptions. 

The `UninitializedPropertySolution.cs` file offers a corrected version, showcasing proper initialization of the property to prevent such problems.