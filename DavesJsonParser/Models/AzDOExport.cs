using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesJsonParser.Models
{
    public class AzDOExport
    {
        public string artifactId { get; set; }
        public string autoCompleteSetBy { get; set; }
        public string closedBy { get; set; }
        public DateTime? closedDate { get; set; }
        public int? codeReviewId { get; set; }
        public string commits { get; set; }
        public Completionoptions completionOptions { get; set; }
        public DateTime? completionQueueTime { get; set; }
        public Createdby createdBy { get; set; }
        public DateTime? creationDate { get; set; }
        public string description { get; set; }
        public string forkSource { get; set; }
        public bool? isDraft { get; set; }
        public Label[] labels { get; set; }
        public Lastmergecommit lastMergeCommit { get; set; }
        public Lastmergesourcecommit lastMergeSourceCommit { get; set; }
        public Lastmergetargetcommit lastMergeTargetCommit { get; set; }
        public string mergeFailureMessage { get; set; }
        public string mergeFailureType { get; set; }
        public string mergeId { get; set; }
        public string mergeOptions { get; set; }
        public string mergeStatus { get; set; }
        public int? pullRequestId { get; set; }
        public string remoteUrl { get; set; }
        public Repository repository { get; set; }
        public Reviewer[] reviewers { get; set; }
        public string sourceRefName { get; set; }
        public string status { get; set; }
        public bool? supportsIterations { get; set; }
        public string targetRefName { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string workItemRefs { get; set; }
    }

    public class Completionoptions
    {
        public string[] autoCompleteIgnoreConfigIds { get; set; }
        public string bypassPolicy { get; set; }
        public string bypassReason { get; set; }
        public bool? deleteSourceBranch { get; set; }
        public string mergeCommitMessage { get; set; }
        public string mergeStrategy { get; set; }
        public string squashMerge { get; set; }
        public bool? transitionWorkItems { get; set; }
        public bool? triggeredByAutoComplete { get; set; }
    }

    public class Createdby
    {
        public string descriptor { get; set; }
        public string directoryAlias { get; set; }
        public string displayName { get; set; }
        public string id { get; set; }
        public string imageUrl { get; set; }
        public object inactive { get; set; }
        public bool? isAadIdentity { get; set; }
        public bool? isContainer { get; set; }
        public bool? isDeletedInOrigin { get; set; }
        public string profileUrl { get; set; }
        public string uniqueName { get; set; }
        public string url { get; set; }
    }

    public class Lastmergecommit
    {
        public string author { get; set; }
        public int? changeCounts { get; set; }
        public string changes { get; set; }
        public string comment { get; set; }
        public string commentTruncated { get; set; }
        public string commitId { get; set; }
        public object committer { get; set; }
        public object parents { get; set; }
        public object push { get; set; }
        public string remoteUrl { get; set; }
        public object statuses { get; set; }
        public string url { get; set; }
        public object workItems { get; set; }
    }

    public class Lastmergesourcecommit
    {
        public string author { get; set; }
        public int? changeCounts { get; set; }
        public object changes { get; set; }
        public string comment { get; set; }
        public string commentTruncated { get; set; }
        public string commitId { get; set; }
        public string committer { get; set; }
        public object parents { get; set; }
        public object push { get; set; }
        public string remoteUrl { get; set; }
        public object statuses { get; set; }
        public string url { get; set; }
        public object workItems { get; set; }
    }

    public class Lastmergetargetcommit
    {
        public string author { get; set; }
        public int? changeCounts { get; set; }
        public object changes { get; set; }
        public string comment { get; set; }
        public string commentTruncated { get; set; }
        public string commitId { get; set; }
        public object committer { get; set; }
        public object parents { get; set; }
        public object push { get; set; }
        public string remoteUrl { get; set; }
        public object statuses { get; set; }
        public string url { get; set; }
        public object workItems { get; set; }
    }

    public class Repository
    {
        public object defaultBranch { get; set; }
        public string id { get; set; }
        public object isFork { get; set; }
        public string name { get; set; }
        public object parentRepository { get; set; }
        public Project project { get; set; }
        public string remoteUrl { get; set; }
        public object size { get; set; }
        public string sshUrl { get; set; }
        public string url { get; set; }
        public object validRemoteUrls { get; set; }
    }

    public class Project
    {
        public string abbreviation { get; set; }
        public string defaultTeamImageUrl { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public DateTime? lastUpDateTime { get; set; }
        public string name { get; set; }
        public object revision { get; set; }
        public string state { get; set; }
        public string url { get; set; }
        public string visibility { get; set; }
    }

    public class Label
    {
        public bool? active { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public object url { get; set; }
    }

    public class Reviewer
    {
        public string descriptor { get; set; }
        public string directoryAlias { get; set; }
        public string displayName { get; set; }
        public bool? hasDeclined { get; set; }
        public string id { get; set; }
        public string imageUrl { get; set; }
        public bool? inactive { get; set; }
        public bool? isAadIdentity { get; set; }
        public bool? isContainer { get; set; }
        public bool? isDeletedInOrigin { get; set; }
        public bool? isFlagged { get; set; }
        public bool? isRequired { get; set; }
        public string profileUrl { get; set; }
        public string reviewerUrl { get; set; }
        public string uniqueName { get; set; }
        public string url { get; set; }
        public int? vote { get; set; }
        public Votedfor[] votedFor { get; set; }
    }

    public class Votedfor
    {
        public string descriptor { get; set; }
        public string directoryAlias { get; set; }
        public string displayName { get; set; }
        public string id { get; set; }
        public string imageUrl { get; set; }
        public bool? inactive { get; set; }
        public bool? isAadIdentity { get; set; }
        public bool? isContainer { get; set; }
        public object isDeletedInOrigin { get; set; }
        public object isRequired { get; set; }
        public object profileUrl { get; set; }
        public string reviewerUrl { get; set; }
        public string uniqueName { get; set; }
        public string url { get; set; }
        public int? vote { get; set; }
        public object votedFor { get; set; }
    }
}