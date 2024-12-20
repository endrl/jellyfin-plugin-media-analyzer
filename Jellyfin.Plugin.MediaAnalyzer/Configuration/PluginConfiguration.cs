using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.MediaAnalyzer.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
    }

    // ===== General settings =====

    /// <summary>
    /// Gets or sets a value indicating whether we run after a library scan.
    /// </summary>
    public bool RunAfterLibraryScan { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether we run after library item added or updated events.
    /// </summary>
    public bool RunAfterAddOrUpdateEvent { get; set; } = true;

    // ===== Analysis settings =====

    /// <summary>
    /// Gets or sets a value indicating whether the episode's fingerprint should be cached to the filesystem.
    /// </summary>
    public bool CacheFingerprints { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether the Blacklist should be resetted.
    /// </summary>
    public bool ResetBlacklist { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether the Blacklist should be created or used.
    /// </summary>
    public bool EnableBlacklist { get; set; } = true;

    /// <summary>
    /// Gets or sets the max degree of parallelism used when analyzing episodes.
    /// </summary>
    public int MaxParallelism { get; set; } = 2;

    /// <summary>
    /// Gets or sets the comma separated list of library names to analyze. If empty, all libraries will be analyzed.
    /// </summary>
    public string SelectedLibraries { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the comma separated list of tv shows and seasons to skip the analyze. Format: "My Show;S01;S02, Another Show".
    /// </summary>
    public string SkippedTvShows { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the comma separated list of movies to skip the analyze.".
    /// </summary>
    public string SkippedMovies { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether to analyze season 0.
    /// </summary>
    public bool AnalyzeSeasonZero { get; set; } = false;

    // ===== Custom analysis settings =====

    /// <summary>
    /// Gets or sets the percentage of each episode's audio track to analyze.
    /// </summary>
    public int AnalysisPercent { get; set; } = 30;

    /// <summary>
    /// Gets or sets the upper limit (in minutes) on the length of each episode's audio track that will be analyzed.
    /// </summary>
    public int AnalysisLengthLimit { get; set; } = 15;

    /// <summary>
    /// Gets or sets the minimum length of similar audio that will be considered an introduction.
    /// </summary>
    public int MinimumIntroDuration { get; set; } = 15;

    /// <summary>
    /// Gets or sets the maximum length of similar audio that will be considered an introduction.
    /// </summary>
    public int MaximumIntroDuration { get; set; } = 120;

    /// <summary>
    /// Gets or sets the minimum length of similar audio that will be considered ending credits.
    /// </summary>
    public int MinimumCreditsDuration { get; set; } = 15;

    /// <summary>
    /// Gets or sets the upper limit (in seconds) on the length of each episode's audio track that will be analyzed when searching for ending credits.
    /// </summary>
    public int MaximumEpisodeCreditsDuration { get; set; } = 240;

    /// <summary>
    /// Gets or sets the upper limit (in seconds) on the length of each movie's audio track that will be analyzed when searching for ending credits.
    /// </summary>
    public int MaximumMovieCreditsDuration { get; set; } = 900;

    /// <summary>
    /// Gets or sets the minimum percentage of a frame that must consist of black pixels before it is considered a black frame.
    /// </summary>
    public int BlackFrameMinimumPercentage { get; set; } = 85;

    /// <summary>
    /// Gets or sets the regular expression used to detect introduction chapters.
    /// </summary>
    public string ChapterAnalyzerIntroductionPattern { get; set; } =
        @"(^|\s)(Intro|Introduction|OP|Opening)(\s|$)";

    /// <summary>
    /// Gets or sets the regular expression used to detect ending credit chapters.
    /// </summary>
    public string ChapterAnalyzerEndCreditsPattern { get; set; } =
        @"(^|\s)(Credits?|Ending|End|Outro)(\s|$)";

    // ===== Internal algorithm settings =====

    /// <summary>
    /// Gets or sets the maximum number of bits (out of 32 total) that can be different between two Chromaprint points before they are considered dissimilar.
    /// Defaults to 6 (81% similar).
    /// </summary>
    public int MaximumFingerprintPointDifferences { get; set; } = 6;

    /// <summary>
    /// Gets or sets the maximum number of seconds that can pass between two similar fingerprint points before a new time range is started.
    /// </summary>
    public double MaximumTimeSkip { get; set; } = 3.5;

    /// <summary>
    /// Gets or sets the amount to shift inverted indexes by.
    /// </summary>
    public int InvertedIndexShift { get; set; } = 2;

    /// <summary>
    /// Gets or sets the maximum amount of noise (in dB) that is considered silent.
    /// Lowering this number will increase the filter's sensitivity to noise.
    /// </summary>
    public int SilenceDetectionMaximumNoise { get; set; } = -50;

    /// <summary>
    /// Gets or sets the minimum duration of audio (in seconds) that is considered silent.
    /// </summary>
    public double SilenceDetectionMinimumDuration { get; set; } = 0.33;
}
