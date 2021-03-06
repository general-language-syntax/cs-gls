using System.Collections.Generic;
using CsGls.Results;
using CsGls.Routing;
using CsGls.Transformers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsGls.Transformers
{
    public class InvocationExpressionVisitor : INodeVisitor<InvocationExpressionSyntax>
    {
        private readonly SemanticModel Model;
        private readonly NodeVisitRouter Router;

        public InvocationExpressionVisitor(SemanticModel model, NodeVisitRouter router)
        {
            this.Model = model;
            this.Router = router;
        }

        public ITransformation VisitNode(InvocationExpressionSyntax node)
        {
            return Complaint.ForUnsupportedNode(node);
        }
    }
}