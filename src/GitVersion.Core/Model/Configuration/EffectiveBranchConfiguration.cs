using GitVersion.Extensions;
using GitVersion.VersionCalculation;

namespace GitVersion.Model.Configurations;

public class EffectiveBranchConfiguration
{
    public IBranch Branch { get; }

    public EffectiveConfiguration Value { get; }

    public EffectiveBranchConfiguration(IBranch branch, EffectiveConfiguration value)
    {
        Branch = branch.NotNull();
        Value = value.NotNull();
    }

    public NextVersion CreateNextVersion(BaseVersion baseVersion, SemanticVersion incrementedVersion)
        => new(incrementedVersion.NotNull(), baseVersion.NotNull(), new(Branch, Value));
}
