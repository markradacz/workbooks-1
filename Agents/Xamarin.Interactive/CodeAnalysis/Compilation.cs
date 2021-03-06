//
// Author:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Xamarin.Interactive.CodeAnalysis.Evaluating;
using Xamarin.Interactive.CodeAnalysis.Events;
using Xamarin.Interactive.CodeAnalysis.Resolving;

namespace Xamarin.Interactive.CodeAnalysis
{
    [JsonObject]
    public sealed class Compilation : ICodeCellEvent
    {
        public CodeCellId CodeCellId { get; }
        public int SubmissionNumber { get; }
        public bool IsResultAnExpression { get; }
        public EvaluationEnvironment EvaluationEnvironment { get; }
        public AssemblyDefinition ExecutableAssembly { get; }
        public IReadOnlyList<AssemblyDefinition> References { get; }

        [JsonConstructor]
        public Compilation (
            CodeCellId codeCellId,
            int submissionNumber,
            EvaluationEnvironment evaluationEnvironment,
            bool isResultAnExpression,
            AssemblyDefinition executableAssembly,
            IReadOnlyList<AssemblyDefinition> references)
        {
            CodeCellId = codeCellId;
            SubmissionNumber = submissionNumber;
            EvaluationEnvironment = evaluationEnvironment;
            IsResultAnExpression = isResultAnExpression;
            ExecutableAssembly = executableAssembly;
            References = references;
        }
    }
}